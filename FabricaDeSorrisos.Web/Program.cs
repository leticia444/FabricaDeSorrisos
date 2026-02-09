using FabricaDeSorrisos.Infrastructure;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// 1. Adiciona o MVC
builder.Services.AddControllersWithViews();

// 2. INJEÇÃO DE DEPENDÊNCIA DA INFRAESTRUTURA (Banco, Identity, Repositórios)
// Isso aqui faz a mágica de conectar no SQL sem precisar de API
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// 2. Configura o pipeline de requisições HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // O valor default de HSTS é 30 dias.
    app.UseHsts();
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication(); // Se tiver login
app.UseAuthorization();

// Rota de Admin
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

// Rota Padrão
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// --- BLOCO DE SEED (ATUALIZADO) ---
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<FabricaDeSorrisos.Infrastructure.Persistence.AppDbContext>();
        var userManager = services.GetRequiredService<UserManager<FabricaDeSorrisos.Infrastructure.Identity.ApplicationUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

        // Chama o seu DatabaseSeeder existente
        await FabricaDeSorrisos.Infrastructure.Persistence.Seed.DatabaseSeeder.SeedAsync(userManager, roleManager, context);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Ocorreu um erro ao rodar o DatabaseSeeder.");
    }
}
// ----------------------------------

app.Run();