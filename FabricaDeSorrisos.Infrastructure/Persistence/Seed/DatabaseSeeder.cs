using FabricaDeSorrisos.Domain.Entities;
using FabricaDeSorrisos.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;

namespace FabricaDeSorrisos.Infrastructure.Persistence.Seed;

public static class DatabaseSeeder
{
    public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, AppDbContext context)
    {
        // 1. Cria as Roles (Permissões) do Identity se não existirem
        if (!await roleManager.RoleExistsAsync("Admin"))
            await roleManager.CreateAsync(new IdentityRole("Admin"));

        if (!await roleManager.RoleExistsAsync("Gerente"))
            await roleManager.CreateAsync(new IdentityRole("Gerente"));

        if (!await roleManager.RoleExistsAsync("Cliente"))
            await roleManager.CreateAsync(new IdentityRole("Cliente"));

        // 2. Cria os Tipos de Usuário do Domínio (nossa tabela personalizada)
        if (!context.TiposUsuarios.Any())
        {
            context.TiposUsuarios.AddRange(
                new TipoUsuario { Nome = "Administrador" },
                new TipoUsuario { Nome = "Gerente" },
                new TipoUsuario { Nome = "Cliente" }
            );
            await context.SaveChangesAsync();
        }

        // 3. Cria um Usuário Admin padrão para você poder logar
        var adminEmail = "admin@loja.com";
        if (await userManager.FindByEmailAsync(adminEmail) == null)
        {
            var user = new ApplicationUser { UserName = adminEmail, Email = adminEmail, EmailConfirmed = true };
            await userManager.CreateAsync(user, "Admin@123"); // Senha padrão
            await userManager.AddToRoleAsync(user, "Admin");

            // Cria o vínculo no Domínio
            var tipoAdmin = context.TiposUsuarios.First(t => t.Nome == "Administrador");
            context.UsuariosDoSistema.Add(new Usuario
            {
                NomeCompleto = "Super Admin",
                Email = adminEmail,
                Cpf = "00000000000",
                IdentityUserId = user.Id, // Link importante!
                TipoUsuario = tipoAdmin
            });
            await context.SaveChangesAsync();
        }
    }
}
