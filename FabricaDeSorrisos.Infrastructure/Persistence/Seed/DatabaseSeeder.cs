using FabricaDeSorrisos.Domain.Entities;
using FabricaDeSorrisos.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore; // Importante para o método Any()

namespace FabricaDeSorrisos.Infrastructure.Persistence.Seed;

public static class DatabaseSeeder
{
    // Definição do registro auxiliar para os usuários iniciais
    private record SeedUser(
        string Email,
        string Password,
        string Role,
        string TipoUsuarioNome,
        string NomeCompleto
    );

    // Lista de usuários que serão criados automaticamente
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
        // 1. ROLES DO IDENTITY (PERMISSÕES)
        // =========================
        var roles = new[] { "Admin", "Gerente", "Cliente" };

        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));
        }

        // =========================
        // 2. FAIXAS ETÁRIAS (NOVO!)
        // =========================
        // Verifica se existe alguma faixa etária. Se não, cria as padrões.
        if (!context.FaixasEtarias.Any())
        {
            var faixas = new List<FaixaEtaria>
            {
                new FaixaEtaria { Descricao = "0 a 18 meses (Bebês)" },
                new FaixaEtaria { Descricao = "1 a 3 anos (Primeira Infância)" },
                new FaixaEtaria { Descricao = "3 a 5 anos (Pré-escolar)" },
                new FaixaEtaria { Descricao = "5 a 7 anos (Alfabetização)" },
                new FaixaEtaria { Descricao = "7 a 10 anos (Crianças maiores)" },
                new FaixaEtaria { Descricao = "+10 anos (Pré-adolescentes)" }
            };

            context.FaixasEtarias.AddRange(faixas);
            await context.SaveChangesAsync();
        }

        // =========================
        // 3. TIPOS DE USUÁRIO (DOMÍNIO)
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
        // 4. USUÁRIOS INICIAIS
        // =========================
        foreach (var seedUser in InitialUsers)
        {
            // Tenta buscar o usuário pelo e-mail
            var user = await userManager.FindByEmailAsync(seedUser.Email);

            if (user == null)
            {
                // Cria o usuário no Identity (Login)
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

            // Garante a role correta (Admin, Gerente, etc)
            if (!await userManager.IsInRoleAsync(user, seedUser.Role))
            {
                await userManager.AddToRoleAsync(user, seedUser.Role);
            }

            // Garante vínculo com a tabela de domínio (UsuariosDoSistema)
            if (!context.UsuariosDoSistema.Any(u => u.IdentityUserId == user.Id))
            {
                var tipoUsuario = context.TiposUsuarios
                    .FirstOrDefault(t => t.Nome == seedUser.TipoUsuarioNome);

                // Só adiciona se encontrou o tipo de usuário
                if (tipoUsuario != null)
                {
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
}