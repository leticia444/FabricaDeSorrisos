using FabricaDeSorrisos.Infrastructure;
using FabricaDeSorrisos.Infrastructure.Identity;
using FabricaDeSorrisos.Infrastructure.Persistence;
using FabricaDeSorrisos.Infrastructure.Persistence.Seed;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// 1. Services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adiciona a Infraestrutura (Banco, Repositórios, Services)
builder.Services.AddInfrastructure(builder.Configuration);

// --- NOVO: Configuração de CORS ---
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowWeb", policy =>
    {
        // Ajuste as portas conforme o seu projeto Web roda (ex: 5001, 7001)
        policy.WithOrigins("https://localhost:7001", "http://localhost:5001", "https://localhost:5001")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
// ----------------------------------

var app = builder.Build();

// 2. Pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// --- NOVO: Ativar CORS ---
app.UseCors("AllowWeb"); // Tem que vir antes de Auth e MapControllers
// -------------------------

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// 3. Seed Data (Admin)
using (var scope = app.Services.CreateScope())
{
    try
    {
        var services = scope.ServiceProvider;
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
        var context = services.GetRequiredService<AppDbContext>();
        await DatabaseSeeder.SeedAsync(userManager, roleManager, context);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro no Seed: {ex.Message}");
    }
}

app.Run();