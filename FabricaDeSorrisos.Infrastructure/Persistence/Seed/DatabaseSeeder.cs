using FabricaDeSorrisos.Domain.Entities;
using FabricaDeSorrisos.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FabricaDeSorrisos.Infrastructure.Persistence.Seed;

public static class DatabaseSeeder
{
    private record SeedUser(string Email, string Password, string Role, string TipoUsuarioNome, string NomeCompleto);

    private static readonly SeedUser[] InitialUsers =
    {
        new("adm@fabricadesorrisos.com", "Admin@123", "Admin", "Administrador", "Administrador do Sistema"),
        new("gerente@fabricadesorrisos.com", "Gerente@123", "Gerente", "Gerente", "Gerente Padrão"),
        new("cliente@fabricadesorrisos.com", "Cliente@123", "Cliente", "Cliente", "Cliente Padrão")
    };

    public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, AppDbContext context)
    {
        await SeedIdentityAsync(userManager, roleManager, context);
        await SeedFaixasEtariasAsync(context);
        await SeedMarcasAsync(context);
        await SeedPersonagensAsync(context);
        await SeedCategoriasAsync(context);
        await SeedBrinquedosAsync(context);
    }

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
                    context.UsuariosDoSistema.Add(new Usuario { NomeCompleto = seedUser.NomeCompleto, Email = seedUser.Email, Cpf = "00000000000", IdentityUserId = user.Id, TipoUsuario = tipo });
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
                new FaixaEtaria { Descricao = "+10 anos (Pré-adolescentes)" },
                new FaixaEtaria { Descricao = "Uso Animal (Pets)" } // <--- ADICIONADO PARA OS PETS
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
                new Marca { Nome = "Grow" },
                new Marca { Nome = "Linha Pet" } // <--- ADICIONADO PARA OS PETS
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
                new SubCategoria { Nome = "Cartas", CategoriaId = catJogos.Id },

                // --- SUBCATEGORIAS DE PETS ADICIONADAS AQUI PARA NUNCA MAIS SUMIREM ---
                new SubCategoria { Nome = "Pássaros", CategoriaId = catPets.Id },
                new SubCategoria { Nome = "Gatos", CategoriaId = catPets.Id },
                new SubCategoria { Nome = "Cachorros", CategoriaId = catPets.Id },
                new SubCategoria { Nome = "Roedores", CategoriaId = catPets.Id }
            );
            await context.SaveChangesAsync();
        }
    }

    private static async Task SeedBrinquedosAsync(AppDbContext context)
    {
        if (!context.Brinquedos.Any())
        {
            var lego = await context.Marcas.FirstAsync(m => m.Nome == "Lego");
            var mattel = await context.Marcas.FirstAsync(m => m.Nome == "Mattel");
            var hasbro = await context.Marcas.FirstAsync(m => m.Nome == "Hasbro");
            var estrela = await context.Marcas.FirstAsync(m => m.Nome == "Estrela");
            var fisher = await context.Marcas.FirstAsync(m => m.Nome == "Fisher-Price");
            var marcaPet = await context.Marcas.FirstAsync(m => m.Nome == "Linha Pet");

            var starWars = await context.Personagens.FirstAsync(p => p.Nome == "Star Wars");
            var barbie = await context.Personagens.FirstAsync(p => p.Nome == "Barbie");
            var hotWheels = await context.Personagens.FirstAsync(p => p.Nome == "Hot Wheels");
            var aranha = await context.Personagens.FirstAsync(p => p.Nome == "Homem-Aranha");
            var semPers = await context.Personagens.FirstAsync(p => p.Nome == "Sem Personagem");

            var catBrinquedos = await context.Categorias.FirstAsync(c => c.Nome == "Brinquedos");
            var catJogos = await context.Categorias.FirstAsync(c => c.Nome == "Jogos");
            var catEducativos = await context.Categorias.FirstAsync(c => c.Nome == "Educativos");
            var catPets = await context.Categorias.FirstAsync(c => c.Nome == "Pets");

            var subBlocos = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Blocos de Montar");
            var subBonecas = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Bonecas e Acessórios");
            var subVeiculos = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Veículos e Pistas");
            var subAcao = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Ação e Aventura");
            var subTabuleiro = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Tabuleiro");
            var subEducativo = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome.Contains("Alfabetização"));

            var subPassaros = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Pássaros");
            var subGatos = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Gatos");
            var subCachorros = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Cachorros");
            var subRoedores = await context.SubCategorias.FirstOrDefaultAsync(s => s.Nome == "Roedores");

            var faixa5a7 = await context.FaixasEtarias.FirstAsync(f => f.Descricao.Contains("5 a 7"));
            var faixa7a10 = await context.FaixasEtarias.FirstAsync(f => f.Descricao.Contains("7 a 10"));
            var faixa10mais = await context.FaixasEtarias.FirstAsync(f => f.Descricao.Contains("+10"));
            var faixaBebe = await context.FaixasEtarias.FirstAsync(f => f.Descricao.Contains("1 a 3"));
            var faixaPet = await context.FaixasEtarias.FirstAsync(f => f.Descricao.Contains("Uso Animal"));

            var produtos = new List<Brinquedo>
            {
                // PRODUTOS ORIGINAIS
                new Brinquedo {
                    Nome = "Lego Star Wars Millennium Falcon", Descricao = "A nave mais famosa da galáxia em blocos de montar.",
                    Preco = 899.90m, Estoque = 10, Ativo = true,
                    MarcaId = lego.Id, CategoriaId = catBrinquedos.Id, SubCategoriaId = subBlocos?.Id, PersonagemId = starWars.Id, FaixaEtariaId = faixa10mais.Id,
                    ImagemUrl = "/imagens/produtos/legostarwars.jpg"
                },
                new Brinquedo {
                    Nome = "Barbie Casa dos Sonhos", Descricao = "A casa da Barbie com 3 andares e piscina.",
                    Preco = 1299.90m, Estoque = 5, Ativo = true,
                    MarcaId = mattel.Id, CategoriaId = catBrinquedos.Id, SubCategoriaId = subBonecas?.Id, PersonagemId = barbie.Id, FaixaEtariaId = faixa5a7.Id,
                    ImagemUrl = "/imagens/produtos/barbiecasadossonhos.png"
                },
                new Brinquedo {
                    Nome = "Pista Hot Wheels Ataque do Tubarão", Descricao = "Fuja do tubarão gigante com seus carrinhos mais rápidos!",
                    Preco = 249.90m, Estoque = 20, Ativo = true,
                    MarcaId = mattel.Id, CategoriaId = catBrinquedos.Id, SubCategoriaId = subVeiculos?.Id, PersonagemId = hotWheels.Id, FaixaEtariaId = faixa5a7.Id,
                    ImagemUrl = "/imagens/produtos/hotwheels.webp"
                },
                new Brinquedo {
                    Nome = "Banco Imobiliário Clássico", Descricao = "O jogo de negócios mais famoso do mundo.",
                    Preco = 129.90m, Estoque = 30, Ativo = true,
                    MarcaId = estrela.Id, CategoriaId = catJogos.Id, SubCategoriaId = subTabuleiro?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixa7a10.Id,
                    ImagemUrl = "/imagens/produtos/bancoimobiliario.jpg"
                },
                new Brinquedo {
                    Nome = "Boneco Homem-Aranha Titan Hero", Descricao = "Figura de ação articulada de 30cm.",
                    Preco = 99.90m, Estoque = 50, Ativo = true,
                    MarcaId = hasbro.Id, CategoriaId = catBrinquedos.Id, SubCategoriaId = subAcao?.Id, PersonagemId = aranha.Id, FaixaEtariaId = faixa5a7.Id,
                    ImagemUrl = "/imagens/produtos/homemaranha.jpg"
                },
                new Brinquedo {
                    Nome = "Cachorrinho Aprender e Brincar", Descricao = "Ensina palavras, cores e sentimentos com músicas.",
                    Preco = 199.90m, Estoque = 15, Ativo = true,
                    MarcaId = fisher.Id, CategoriaId = catEducativos.Id, SubCategoriaId = subEducativo?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaBebe.Id,
                    ImagemUrl = "/imagens/produtos/cachorrinho.jpg"
                },

                // PÁSSAROS
                new Brinquedo {
                    Nome = "Bicicleta para pássaros", Descricao = "Bicicleta interativa projetada especialmente para o treinamento e entretenimento de pássaros. Desenvolve a inteligência, o equilíbrio e a coordenação motora do seu pet voador.",
                    Preco = 45.90m, Estoque = 20, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subPassaros?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/bicicleta.webp"
                },
                new Brinquedo {
                    Nome = "Skate para pássaros", Descricao = "Mini skate divertido ideal para manter seu pássaro ativo e estimulado. Perfeito para calopsitas e periquitos, possui lixa levemente antiderrapante e rodinhas seguras.",
                    Preco = 35.90m, Estoque = 25, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subPassaros?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/skate.webp"
                },
                new Brinquedo {
                    Nome = "Kit pega argola e palito para pássaros", Descricao = "Kit educativo e interativo desenvolvido para estimular a inteligência e destreza mental do seu pássaro. O pacote inclui uma base firme, argolas coloridas e palitos de encaixe.",
                    Preco = 55.00m, Estoque = 15, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subPassaros?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/palitoEArgola.webp"
                },
                new Brinquedo {
                    Nome = "Banheira para pássaros", Descricao = "Banheira prática e espaçosa para a higiene e o refresco do seu pássaro nos dias quentes. Extremamente fácil de higienizar, pode ser acoplada nas grades da gaiola.",
                    Preco = 29.90m, Estoque = 30, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subPassaros?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/banheira.jpg"
                },
                new Brinquedo {
                    Nome = "Playground gigante para pássaros", Descricao = "Centro de diversão completo em madeira natural com poleiros, balanços, escadas verticais e brinquedos de bicar. Proporciona um ambiente rico e estimulante.",
                    Preco = 189.90m, Estoque = 10, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subPassaros?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/playgroundPassaro.webp"
                },
                new Brinquedo {
                    Nome = "Playground twister para roedores e pássaros", Descricao = "Playground versátil em formato twister que garante horas de diversão. Fabricado com madeira natural atóxica e cordas de algodão coloridas.",
                    Preco = 129.90m, Estoque = 12, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subPassaros?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/playground.jpg"
                },

                // GATOS
                new Brinquedo {
                    Nome = "Torre bolinhas corre corre", Descricao = "Torre interativa com 3 andares de trilhos e bolinhas coloridas que giram sem parar. Desenvolvida para aguçar o instinto de caça do gato.",
                    Preco = 79.90m, Estoque = 22, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subGatos?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/corre.webp"
                },
                new Brinquedo {
                    Nome = "Túnel com bolinha", Descricao = "Túnel dobrável e flexível que desperta a curiosidade do seu felino. Com uma bolinha de pelúcia pendurada na entrada, é o esconderijo perfeito.",
                    Preco = 89.90m, Estoque = 18, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subGatos?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/tunelGaro.webp"
                },
                new Brinquedo {
                    Nome = "Kit brinquedos para gatos com 3 unidades", Descricao = "Conjunto especial de diversão contendo texturas e barulhos variados. Perfeito para o enriquecimento ambiental da sua casa.",
                    Preco = 39.90m, Estoque = 40, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subGatos?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/bolaGato.webp"
                },
                new Brinquedo {
                    Nome = "Arranhador de estrela com mola", Descricao = "Arranhador altamente resistente com base estilizada em formato de estrela e uma mola vertical flexível com pompom na ponta.",
                    Preco = 115.00m, Estoque = 15, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subGatos?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/arranhador.webp"
                },
                new Brinquedo {
                    Nome = "Bola interativa para gatos e cachorros", Descricao = "Bola inteligente automática que se move sozinha de forma aleatória pelo ambiente. Ela desvia de obstáculos e simula presa viva.",
                    Preco = 65.90m, Estoque = 25, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subGatos?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/interativa.jpg"
                },

                // CACHORROS
                new Brinquedo {
                    Nome = "Bola de tênis", Descricao = "A bola clássica e super resistente, perfeita para jogar, buscar e morder em praças ou áreas abertas.",
                    Preco = 19.90m, Estoque = 50, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subCachorros?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/bolaDog.webp"
                },
                new Brinquedo {
                    Nome = "Osso rosa", Descricao = "Osso fabricado em borracha TPR maciça e 100% atóxica, desenvolvido para suportar mordidas fortes de cães de médio porte.",
                    Preco = 25.90m, Estoque = 35, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subCachorros?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/osso.webp"
                },
                new Brinquedo {
                    Nome = "Galo que apita", Descricao = "Brinquedo sonoro hilário em formato de galo de borracha. Emite um som alto e divertido ao ser apertado ou mordido.",
                    Preco = 42.50m, Estoque = 28, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subCachorros?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/galo.webp"
                },
                new Brinquedo {
                    Nome = "Macaco pelúcia com apito", Descricao = "Pelúcia extremamente macia, aconchegante e segura para cães. Fabricada com costuras reforçadas e um apito interno embutido.",
                    Preco = 55.90m, Estoque = 20, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subCachorros?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/macaco.webp"
                },
                new Brinquedo {
                    Nome = "Bola interativa para gatos e cachorros", Descricao = "Bola inteligente automática que se move sozinha de forma aleatória pelo ambiente. Ela desvia de obstáculos e simula presa viva.",
                    Preco = 65.90m, Estoque = 25, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subCachorros?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/interativa.jpg"
                },

                // ROEDORES
                new Brinquedo {
                    Nome = "Toca para roedores", Descricao = "Toca espaçosa, aconchegante e escura, oferecendo o refúgio perfeito para hamsters e porquinhos-da-índia.",
                    Preco = 38.00m, Estoque = 18, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subRoedores?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/toca.webp"
                },
                new Brinquedo {
                    Nome = "Cenoura para roedores", Descricao = "Brinquedo lúdico em formato de cenoura, 100% natural e seguro. Auxilia no desgaste contínuo e vital dos dentes dos roedores.",
                    Preco = 22.90m, Estoque = 40, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subRoedores?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/cenoura.webp"
                },
                new Brinquedo {
                    Nome = "Roda para roedores", Descricao = "Roda de exercícios essencial com sistema de rolamento super silencioso. Ideal para manter o seu roedor em excelente forma física.",
                    Preco = 65.90m, Estoque = 15, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subRoedores?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/roda.png"
                },
                new Brinquedo {
                    Nome = "Moinho interativo", Descricao = "Moinho giratório feito de madeira sustentável, projetado estrategicamente para o enriquecimento ambiental de gaiolas.",
                    Preco = 75.00m, Estoque = 10, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subRoedores?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/moinho.png"
                },
                new Brinquedo {
                    Nome = "Playground twister para roedores e pássaros", Descricao = "Playground versátil em formato twister. Fabricado com madeira natural atóxica e cordas de algodão, é o brinquedo ideal para roer e escalar.",
                    Preco = 129.90m, Estoque = 12, Ativo = true,
                    MarcaId = marcaPet.Id, CategoriaId = catPets.Id, SubCategoriaId = subRoedores?.Id, PersonagemId = semPers.Id, FaixaEtariaId = faixaPet.Id,
                    ImagemUrl = "/imagens/produtos/playground.jpg"
                }
            };

            context.Brinquedos.AddRange(produtos);
            await context.SaveChangesAsync();
        }
    }
}