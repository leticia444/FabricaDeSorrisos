using FabricaDeSorrisos.Domain.Entities;
using FabricaDeSorrisos.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace FabricaDeSorrisos.Infrastructure.Persistence.Seed;

public static class DatabaseSeeder
{
    private record SeedUser(
        string Email,
        string Password,
        string Role,
        string TipoUsuarioNome,
        string NomeCompleto
    );

    private static readonly SeedUser[] InitialUsers =
    {
        new(
            Email: "adm@fabricadesorrisos.com",
            Password: "Admin@123",
            Role: "Admin",
            TipoUsuarioNome: "Administrador",
            NomeCompleto: "Administrador do Sistema"
        ),
        new(
            Email: "gerente@fabricadesorrisos.com",
            Password: "Gerente@123",
            Role: "Gerente",
            TipoUsuarioNome: "Gerente",
            NomeCompleto: "Gerente Padrão"
        ),
        new(
            Email: "cliente@fabricadesorrisos.com",
            Password: "Cliente@123",
            Role: "Cliente",
            TipoUsuarioNome: "Cliente",
            NomeCompleto: "Cliente Padrão"
        )
    };

    public static async Task SeedAsync(
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        AppDbContext context)
    {
        // =========================
        // 1. ROLES DO IDENTITY
        // =========================
        var roles = new[] { "Admin", "Gerente", "Cliente" };

        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));
        }

        // =========================
        // 2. TIPOS DE USUÁRIO (DOMÍNIO)
        // =========================
        if (!context.TiposUsuarios.Any())
        {
            context.TiposUsuarios.AddRange(
                new TipoUsuario { Nome = "Administrador" },
                new TipoUsuario { Nome = "Gerente" },
                new TipoUsuario { Nome = "Cliente" }
            );
            await context.SaveChangesAsync();
        }

        // =========================
        // 3. USUÁRIOS INICIAIS
        // =========================
        foreach (var seedUser in InitialUsers)
        {
            var user = await userManager.FindByEmailAsync(seedUser.Email);

            if (user == null)
            {
                user = new ApplicationUser
                {
                    UserName = seedUser.Email,
                    Email = seedUser.Email,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(user, seedUser.Password);

                if (!result.Succeeded)
                {
                    var errors = string.Join(" | ", result.Errors.Select(e => e.Description));
                    throw new Exception($"Erro ao criar usuário {seedUser.Email}: {errors}");
                }
            }

            // Garante a role correta
            if (!await userManager.IsInRoleAsync(user, seedUser.Role))
            {
                await userManager.AddToRoleAsync(user, seedUser.Role);
            }

            // Garante vínculo com o domínio
            if (!context.UsuariosDoSistema.Any(u => u.IdentityUserId == user.Id))
            {
                var tipoUsuario = context.TiposUsuarios
                    .First(t => t.Nome == seedUser.TipoUsuarioNome);

                context.UsuariosDoSistema.Add(new Usuario
                {
                    NomeCompleto = seedUser.NomeCompleto,
                    Email = seedUser.Email,
                    Cpf = "00000000000",
                    IdentityUserId = user.Id,
                    TipoUsuario = tipoUsuario
                });

                await context.SaveChangesAsync();
            }
        }
    }
}
