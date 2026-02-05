using Microsoft.AspNetCore.Identity;

namespace FabricaDeSorrisos.Infrastructure.Identity
{
    public static class IdentitySeed
    {
        public static async Task SeedAsync(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            // ===== ROLES =====
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            // ===== USUÁRIO ADMIN =====
            var adminEmail = "admin@fabricadesorrisos.com";

            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                adminUser = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(
                    adminUser,
                    "Admin@123"
                );

                if (!result.Succeeded)
                {
                    var errors = string.Join(
                        " | ",
                        result.Errors.Select(e => e.Description)
                    );

                    throw new Exception($"Erro ao criar usuário admin: {errors}");
                }
            }

            // ===== VINCULAR ROLE =====
            if (!await userManager.IsInRoleAsync(adminUser, "Admin"))
            {
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }
    }
}
