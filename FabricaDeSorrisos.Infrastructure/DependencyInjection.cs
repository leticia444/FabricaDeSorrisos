using FabricaDeSorrisos.Application.Abstractions.Repositories;
using FabricaDeSorrisos.Application.Abstractions.Services;
using FabricaDeSorrisos.Infrastructure.Identity;
using FabricaDeSorrisos.Infrastructure.Persistence;
using FabricaDeSorrisos.Infrastructure.Repositories;
using FabricaDeSorrisos.Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FabricaDeSorrisos.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // 1. Configurar o Banco de Dados SQL Server
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));

        // 2. Configurar o Identity (Sistema de Login)
        services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

        // Configurações de senha (opcional, para facilitar testes deixa fraca)
        services.Configure<IdentityOptions>(options =>
        {
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 3; // Senha curta para testar
        });


        // 3. Registrar Repositórios
        services.AddScoped<IBrinquedoRepository, EfBrinquedoRepository>();
        services.AddScoped<ICategoriaRepository, EfCategoriaRepository>();
        services.AddScoped<IMarcaRepository, EfMarcaRepository>();
        services.AddScoped<IPersonagemRepository, EfPersonagemRepository>();
        services.AddScoped<IFaixaEtariaRepository, EfFaixaEtariaRepository>();
        // Adicione os de Avaliação e Favorito se criou os arquivos

        // 4. Registrar Serviços de Leitura
        services.AddScoped<IBrinquedoQueryService, BrinquedoQueryService>();
        services.AddScoped<ICatalogLookupService, CatalogLookupService>();


        return services;
    }
}
