using FabricaDeSorrisos.Infrastructure;
using FabricaDeSorrisos.Infrastructure.Identity;
using FabricaDeSorrisos.Infrastructure.Persistence;
using FabricaDeSorrisos.Infrastructure.Persistence.Seed;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// 1. Services (Controllers, Swagger)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<JwtTokenService>();

// 2. Infraestrutura (Banco, EF, Identity, JWT, etc.)
builder.Services.AddInfrastructure(builder.Configuration);

// 3. CORS (para Web/Desktop consumirem a API)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowWeb", policy =>
    {
        policy.WithOrigins(
                "https://localhost:7001",
                "http://localhost:5001",
                "https://localhost:5001")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

var app = builder.Build();

// 4. Pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// CORS precisa vir antes de Auth
app.UseCors("AllowWeb");

app.UseAuthentication();
app.UseAuthorization();

// 5. Seed (popula o banco com Admin, Roles, etc.)
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
        var context = services.GetRequiredService<AppDbContext>();

        await DatabaseSeeder.SeedAsync(userManager, roleManager, context);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Erro ao executar o seed do banco de dados.");
    }
}

// 6. Controllers
app.MapControllers();

app.Run();