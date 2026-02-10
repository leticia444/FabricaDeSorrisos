using FabricaDeSorrisos.Domain.Entities;
using FabricaDeSorrisos.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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

    private static readonly SeedUser[] InitialUsers =
    {
        new("adm@fabricadesorrisos.com", "Admin@123", "Admin", "Administrador", "Administrador do Sistema"),
        new("gerente@fabricadesorrisos.com", "Gerente@123", "Gerente", "Gerente", "Gerente Padrão"),
        new("cliente@fabricadesorrisos.com", "Cliente@123", "Cliente", "Cliente", "Cliente Padrão")
    };

    public static async Task SeedAsync(
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        AppDbContext context)
    {
        // 1. IDENTITY (USUÁRIOS E ROLES)
        await SeedIdentityAsync(userManager, roleManager, context);

        // 2. FAIXAS ETÁRIAS
        await SeedFaixasEtariasAsync(context);

        // 3. MARCAS
        await SeedMarcasAsync(context);

        // 4. PERSONAGENS
        await SeedPersonagensAsync(context);

        // 5. CATEGORIAS E SUBCATEGORIAS
        await SeedCategoriasAsync(context);

        // 6. BRINQUEDOS (PRODUTOS) - Agora com Subcategorias!
        await SeedBrinquedosAsync(context);
    }

    // =========================================================================
    // MÉTODOS AUXILIARES
    // =========================================================================

    private static async Task SeedIdentityAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, AppDbContext context)
    {
        var roles = new[] { "Admin", "Gerente", "Cliente" };
        foreach (var role in roles)
        {
            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));
        }

        if (!context.TiposUsuarios.Any())
        {
            context.TiposUsuarios.AddRange(
                new TipoUsuario { Nome = "Administrador" },
                new TipoUsuario { Nome = "Gerente" },
                new TipoUsuario { Nome = "Cliente" }
            );
            await context.SaveChangesAsync();
        }

        foreach (var seedUser in InitialUsers)
        {
            var user = await userManager.FindByEmailAsync(seedUser.Email);
            if (user == null)
            {
                user = new ApplicationUser { UserName = seedUser.Email, Email = seedUser.Email, EmailConfirmed = true };
                var result = await userManager.CreateAsync(user, seedUser.Password);
                if (!result.Succeeded) throw new Exception($"Erro ao criar {seedUser.Email}");
            }

            if (!await userManager.IsInRoleAsync(user, seedUser.Role))
                await userManager.AddToRoleAsync(user, seedUser.Role);

            if (!context.UsuariosDoSistema.Any(u => u.IdentityUserId == user.Id))
            {
                var tipo = await context.TiposUsuarios.FirstOrDefaultAsync(t => t.Nome == seedUser.TipoUsuarioNome);
                if (tipo != null)
                {
                    context.UsuariosDoSistema.Add(new Usuario
                    {
                        NomeCompleto = seedUser.NomeCompleto,
                        Email = seedUser.Email,
                        Cpf = "00000000000",
                        IdentityUserId = user.Id,
                        TipoUsuario = tipo
                    });
                    await context.SaveChangesAsync();
                }
            }
        }
    }

    private static async Task SeedFaixasEtariasAsync(AppDbContext context)
    {
        if (!context.FaixasEtarias.Any())
        {
            context.FaixasEtarias.AddRange(
                new FaixaEtaria { Descricao = "0 a 18 meses (Bebês)" },
                new FaixaEtaria { Descricao = "1 a 3 anos (Primeira Infância)" },
                new FaixaEtaria { Descricao = "3 a 5 anos (Pré-escolar)" },
                new FaixaEtaria { Descricao = "5 a 7 anos (Alfabetização)" },
                new FaixaEtaria { Descricao = "7 a 10 anos (Crianças maiores)" },
                new FaixaEtaria { Descricao = "+10 anos (Pré-adolescentes)" }
            );
            await context.SaveChangesAsync();
        }
    }

    private static async Task SeedMarcasAsync(AppDbContext context)
    {
        if (!context.Marcas.Any())
        {
            context.Marcas.AddRange(
                new Marca { Nome = "Lego" },
                new Marca { Nome = "Mattel" },
                new Marca { Nome = "Hasbro" },
                new Marca { Nome = "Fisher-Price" },
                new Marca { Nome = "Estrela" },
                new Marca { Nome = "Candide" },
                new Marca { Nome = "Grow" }
            );
            await context.SaveChangesAsync();
        }
    }

    private static async Task SeedPersonagensAsync(AppDbContext context)
    {
        if (!context.Personagens.Any())
        {
            context.Personagens.AddRange(
                new Personagem { Nome = "Sem Personagem" },
                new Personagem { Nome = "Barbie" },
                new Personagem { Nome = "Hot Wheels" },
                new Personagem { Nome = "Homem-Aranha" },
                new Personagem { Nome = "Frozen" },
                new Personagem { Nome = "Star Wars" },
                new Personagem { Nome = "Patrulha Canina" },
                new Personagem { Nome = "Peppa Pig" }
            );
            await context.SaveChangesAsync();
        }
    }

    private static async Task SeedCategoriasAsync(AppDbContext context)
    {
        if (!context.Categorias.Any())
        {
            var catBrinquedos = new Categoria { Nome = "Brinquedos" };
            var catEducativos = new Categoria { Nome = "Educativos" };
            var catJogos = new Categoria { Nome = "Jogos" };
            var catPets = new Categoria { Nome = "Pets" };

            context.Categorias.AddRange(catBrinquedos, catEducativos, catJogos, catPets);
            await context.SaveChangesAsync();

            context.SubCategorias.AddRange(
                new SubCategoria { Nome = "Bonecas e Acessórios", CategoriaId = catBrinquedos.Id },
                new SubCategoria { Nome = "Veículos e Pistas", CategoriaId = catBrinquedos.Id },
                new SubCategoria { Nome = "Blocos de Montar", CategoriaId = catBrinquedos.Id },
                new SubCategoria { Nome = "Ação e Aventura", CategoriaId = catBrinquedos.Id },
                new SubCategoria { Nome = "Quebra-Cabeças", CategoriaId = catEducativos.Id },
                new SubCategoria { Nome = "Alfabetização e Números", CategoriaId = catEducativos.Id },
                new SubCategoria { Nome = "Tabuleiro", CategoriaId = catJogos.Id },
                new SubCategoria { Nome = "Cartas", CategoriaId = catJogos.Id }
            );
            await context.SaveChangesAsync();
        }
    }

    private static async Task SeedBrinquedosAsync(AppDbContext context)
    {
        // Se já existirem brinquedos, não faz nada (para evitar duplicação)
        if (!context.Brinquedos.Any())
        {
            // 1. Recupera as entidades auxiliares para fazer as ligações
            var lego = await context.Marcas.FirstAsync(m => m.Nome == "Lego");
            var mattel = await context.Marcas.FirstAsync(m => m.Nome == "Mattel");
            var hasbro = await context.Marcas.FirstAsync(m => m.Nome == "Hasbro");
            var estrela = await context.Marcas.FirstAsync(m => m.Nome == "Estrela");
            var fisher = await context.Marcas.FirstAsync(m => m.Nome == "Fisher-Price");

            var starWars = await context.Personagens.FirstAsync(p => p.Nome == "Star Wars");
            var barbie = await context.Personagens.FirstAsync(p => p.Nome == "Barbie");
            var hotWheels = await context.Personagens.FirstAsync(p => p.Nome == "Hot Wheels");
            var aranha = await context.Personagens.FirstAsync(p => p.Nome == "Homem-Aranha");
            var semPers = await context.Personagens.FirstAsync(p => p.Nome == "Sem Personagem");

            var catBrinquedos = await context.Categorias.FirstAsync(c => c.Nome == "Brinquedos");
            var catJogos = await context.Categorias.FirstAsync(c => c.Nome == "Jogos");
            var catEducativos = await context.Categorias.FirstAsync(c => c.Nome == "Educativos");

            // 2. RECUPERA AS SUBCATEGORIAS (IMPORTANTE!)
            // Usamos FirstOrDefault para evitar erro caso a string esteja ligeiramente diferente, mas idealmente deve ser igual ao SeedCategoriasAsync
            var subBlocos = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Blocos de Montar");
            var subBonecas = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Bonecas e Acessórios");
            var subVeiculos = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Veículos e Pistas");
            var subAcao = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Ação e Aventura");
            var subTabuleiro = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Tabuleiro");
            var subEducativo = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome.Contains("Alfabetização")); // Pega por parte do nome para ser mais seguro

            var faixa5a7 = await context.FaixasEtarias.FirstAsync(f => f.Descricao.Contains("5 a 7"));
            var faixa7a10 = await context.FaixasEtarias.FirstAsync(f => f.Descricao.Contains("7 a 10"));
            var faixa10mais = await context.FaixasEtarias.FirstAsync(f => f.Descricao.Contains("+10"));
            var faixaBebe = await context.FaixasEtarias.FirstAsync(f => f.Descricao.Contains("1 a 3"));

            // 3. Criação dos Brinquedos com SubCategoriaId preenchido
            var produtos = new List<Brinquedo>
            {
                // Lego -> Blocos
                new Brinquedo {
                    Nome = "Lego Star Wars Millennium Falcon",
                    Descricao = "A nave mais famosa da galáxia em blocos de montar.",
                    Preco = 899.90m,
                    Estoque = 10,
                    Ativo = true,
                    MarcaId = lego.Id,
                    CategoriaId = catBrinquedos.Id,
                    SubCategoriaId = subBlocos?.Id, // Vincula à Subcategoria
                    PersonagemId = starWars.Id,
                    FaixaEtariaId = faixa10mais.Id,
                    ImagemUrl = "https://m.media-amazon.com/images/I/81X8gK1M+xL._AC_SX679_.jpg"
                },
                // Barbie -> Bonecas
                new Brinquedo {
                    Nome = "Barbie Casa dos Sonhos",
                    Descricao = "A casa da Barbie com 3 andares e piscina.",
                    Preco = 1299.90m,
                    Estoque = 5,
                    Ativo = true,
                    MarcaId = mattel.Id,
                    CategoriaId = catBrinquedos.Id,
                    SubCategoriaId = subBonecas?.Id, // Vincula à Subcategoria
                    PersonagemId = barbie.Id,
                    FaixaEtariaId = faixa5a7.Id,
                    ImagemUrl = "https://m.media-amazon.com/images/I/81x1pA-xHUL._AC_SX679_.jpg"
                },
                // Hot Wheels -> Veículos
                new Brinquedo {
                    Nome = "Pista Hot Wheels Ataque do Tubarão",
                    Descricao = "Fuja do tubarão gigante com seus carrinhos mais rápidos!",
                    Preco = 249.90m,
                    Estoque = 20,
                    Ativo = true,
                    MarcaId = mattel.Id,
                    CategoriaId = catBrinquedos.Id,
                    SubCategoriaId = subVeiculos?.Id, // Vincula à Subcategoria
                    PersonagemId = hotWheels.Id,
                    FaixaEtariaId = faixa5a7.Id,
                    ImagemUrl = "https://m.media-amazon.com/images/I/81-y4+XgJHL._AC_SX679_.jpg"
                },
                // Banco Imobiliário -> Tabuleiro
                new Brinquedo {
                    Nome = "Banco Imobiliário Clássico",
                    Descricao = "O jogo de negócios mais famoso do mundo.",
                    Preco = 129.90m,
                    Estoque = 30,
                    Ativo = true,
                    MarcaId = estrela.Id,
                    CategoriaId = catJogos.Id,
                    SubCategoriaId = subTabuleiro?.Id, // Vincula à Subcategoria
                    PersonagemId = semPers.Id,
                    FaixaEtariaId = faixa7a10.Id,
                    ImagemUrl = "https://m.media-amazon.com/images/I/81g7V5-g15L._AC_SX679_.jpg"
                },
                // Homem-Aranha -> Ação
                new Brinquedo {
                    Nome = "Boneco Homem-Aranha Titan Hero",
                    Descricao = "Figura de ação articulada de 30cm.",
                    Preco = 99.90m,
                    Estoque = 50,
                    Ativo = true,
                    MarcaId = hasbro.Id,
                    CategoriaId = catBrinquedos.Id,
                    SubCategoriaId = subAcao?.Id, // Vincula à Subcategoria
                    PersonagemId = aranha.Id,
                    FaixaEtariaId = faixa5a7.Id,
                    ImagemUrl = "https://m.media-amazon.com/images/I/71VjM5LOeYL._AC_SX679_.jpg"
                },
                // Fisher Price -> Educativo
                new Brinquedo {
                    Nome = "Cachorrinho Aprender e Brincar",
                    Descricao = "Ensina palavras, cores e sentimentos com músicas.",
                    Preco = 199.90m,
                    Estoque = 15,
                    Ativo = true,
                    MarcaId = fisher.Id,
                    CategoriaId = catEducativos.Id,
                    SubCategoriaId = subEducativo?.Id, // Vincula à Subcategoria
                    PersonagemId = semPers.Id,
                    FaixaEtariaId = faixaBebe.Id,
                    ImagemUrl = "https://m.media-amazon.com/images/I/71P4d+lqWUL._AC_SX679_.jpg"
                }
            };

            context.Brinquedos.AddRange(produtos);
            await context.SaveChangesAsync();
        }
    }
}