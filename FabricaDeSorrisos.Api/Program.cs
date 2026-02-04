using FabricaDeSorrisos.Infrastructure; // Para usar o AddInfrastructure
using FabricaDeSorrisos.Infrastructure.Identity;
using FabricaDeSorrisos.Infrastructure.Persistence;
using FabricaDeSorrisos.Infrastructure.Persistence.Seed;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// 1. Adiciona Controllers e Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 2. Adiciona a camada de Infraestrutura (Banco, EF, Identity)
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

// 3. Configura o Pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Importante: Autenticação antes de Autorização
app.UseAuthentication();
app.UseAuthorization();

// 4. Roda o Seed (popula o banco com dados iniciais: Admin, Roles, etc.)
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
        var context = services.GetRequiredService<AppDbContext>();

        // Seed de Identity + dados iniciais
        await DatabaseSeeder.SeedAsync(userManager, roleManager, context);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Erro ao executar o seed do banco de dados.");
    }
}

// 5. Mapeia os Controllers
app.MapControllers();

app.Run();
