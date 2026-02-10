using FabricaDeSorrisos.Application.Abstractions.Repositories;
using FabricaDeSorrisos.Application.DTOs;
using FabricaDeSorrisos.Infrastructure.Persistence;
using FabricaDeSorrisos.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace FabricaDeSorrisos.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IBrinquedoRepository _brinquedoRepo;
    private readonly IMarcaRepository _marcaRepo;
    private readonly ICategoriaRepository _categoriaRepo;
    private readonly IFaixaEtariaRepository _faixaRepo;
    private readonly IPersonagemRepository _personagemRepo;
    private readonly AppDbContext _context;

    public HomeController(
        ILogger<HomeController> logger,
        IBrinquedoRepository brinquedoRepo,
        IMarcaRepository marcaRepo,
        ICategoriaRepository categoriaRepo,
        IFaixaEtariaRepository faixaRepo,
        IPersonagemRepository personagemRepo,
        AppDbContext context)
    {
        _logger = logger;
        _brinquedoRepo = brinquedoRepo;
        _marcaRepo = marcaRepo;
        _categoriaRepo = categoriaRepo;
        _faixaRepo = faixaRepo;
        _personagemRepo = personagemRepo;
        _context = context;
    }

    // =============================================================
    // 1. HOME (VITRINE) - A página bonitona com carrossel
    // =============================================================
    public async Task<IActionResult> Index()
    {
        // Pega apenas alguns destaques para a Home
        var destaques = await _brinquedoRepo.GetAllAsync();

        var viewModel = new CatalogViewModel
        {
            // Pega os 6 primeiros produtos para mostrar em "Destaques"
            Produtos = new PagedResult<BrinquedoDto>
            {
                Items = destaques.Take(6).Select(b => new BrinquedoDto
                {
                    Id = b.Id,
                    Nome = b.Nome,
                    Preco = b.Preco,
                    ImagemUrl = b.ImagemUrl,
                    Estoque = b.Estoque,
                    Ativo = b.Ativo,
                    Marca = b.Marca?.Nome,
                    Categoria = b.Categoria?.Nome
                }).ToList()
            }
        };

        return View(viewModel);
    }

    // =============================================================
    // 2. BUSCA (CATÁLOGO) - A página nova com filtros laterais
    // =============================================================
    [HttpGet]
    public async Task<IActionResult> Busca(
            int pageIndex = 1,
            string? termoBusca = null,
            int? marcaId = null,
            int? categoriaId = null,
            int? subCategoriaId = null, // <--- Novo parâmetro
            int? faixaEtariaId = null,
            int? personagemId = null)
    {
        var todosBrinquedos = await _brinquedoRepo.GetAllAsync();
        var query = todosBrinquedos.Where(b => b.Ativo).AsEnumerable();

        // 1. Aplica Filtros Principais
        if (!string.IsNullOrEmpty(termoBusca))
        {
            query = query.Where(b =>
                (b.Nome != null && b.Nome.Contains(termoBusca, StringComparison.OrdinalIgnoreCase)) ||
                (b.Marca != null && b.Marca.Nome.Contains(termoBusca, StringComparison.OrdinalIgnoreCase)) ||
                (b.Categoria != null && b.Categoria.Nome.Contains(termoBusca, StringComparison.OrdinalIgnoreCase))
            );
        }

        if (marcaId.HasValue) query = query.Where(b => b.MarcaId == marcaId.Value);

        // Se tiver Categoria, filtra por ela
        if (categoriaId.HasValue) query = query.Where(b => b.CategoriaId == categoriaId.Value);

        // Se tiver Subcategoria, filtra por ela
        if (subCategoriaId.HasValue) query = query.Where(b => b.SubCategoriaId == subCategoriaId.Value);

        if (faixaEtariaId.HasValue) query = query.Where(b => b.FaixaEtariaId == faixaEtariaId.Value);
        if (personagemId.HasValue) query = query.Where(b => b.PersonagemId == personagemId.Value);

        // 2. Lógica Dinâmica da Sidebar (Categorias vs Subcategorias)
        var listaCategorias = (await _categoriaRepo.GetAllAsync()).Select(c => new CategoriaDto { Id = c.Id, Nome = c.Nome }).ToList();
        var listaSubCategorias = new List<SubCategoriaDto>();

        // Se uma categoria foi selecionada, buscamos as subcategorias DELA no banco
        if (categoriaId.HasValue)
        {
            // Usando o _context direto para agilizar, já que não temos SubCategoriaRepo injetado ainda
            // Se você tiver o repo, use ele. Aqui vou usar o Context que injetamos antes.
            listaSubCategorias = await _context.SubCategorias
                .Where(s => s.CategoriaId == categoriaId.Value)
                .Select(s => new SubCategoriaDto { Id = s.Id, Nome = s.Nome })
                .ToListAsync();
        }

        // 3. Paginação
        int pageSize = 12;
        int totalItems = query.Count();
        var itensPagina = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();

        var viewModel = new CatalogViewModel
        {
            // Listas
            Marcas = (await _marcaRepo.GetAllAsync()).Select(m => new MarcaDto { Id = m.Id, Nome = m.Nome }).ToList(),
            FaixasEtarias = (await _faixaRepo.GetAllAsync()).Select(f => new FaixaEtariaDto { Id = f.Id, Descricao = f.Descricao }).ToList(),
            Personagens = (await _personagemRepo.GetAllAsync()).Select(p => new PersonagemDto { Id = p.Id, Nome = p.Nome }).ToList(),
            Categorias = listaCategorias,
            SubCategorias = listaSubCategorias, // Lista nova populada dinamicamente

            // Estado dos Filtros
            TermoBusca = termoBusca,
            MarcaId = marcaId,
            CategoriaId = categoriaId,
            SubCategoriaId = subCategoriaId,
            FaixaEtariaId = faixaEtariaId,
            PersonagemId = personagemId,
            PageIndex = pageIndex,

            // Produtos
            Produtos = new PagedResult<BrinquedoDto>
            {
                Items = itensPagina.Select(b => new BrinquedoDto
                {
                    Id = b.Id,
                    Nome = b.Nome,
                    Preco = b.Preco,
                    ImagemUrl = b.ImagemUrl,
                    Estoque = b.Estoque,
                    Ativo = b.Ativo,
                    Marca = b.Marca?.Nome ?? "",
                    Categoria = b.Categoria?.Nome ?? ""
                }).ToList(),
                TotalCount = totalItems,
                PageIndex = pageIndex,
                PageSize = pageSize
            }
        };

        return View("Busca", viewModel);
    }

    // =============================================================
    // 3. AUTOCOMPLETE (Usado pelo JS)
    // =============================================================
    [HttpGet]
    public async Task<IActionResult> BuscarSugestoes(string termo)
    {
        if (string.IsNullOrEmpty(termo) || termo.Length < 2) return Json(new List<string>());

        var query = await _context.Brinquedos
            .Include(b => b.Marca).Include(b => b.Categoria).Include(b => b.Personagem)
            .Where(b => b.Ativo && (
                b.Nome.Contains(termo) || b.Marca.Nome.Contains(termo) ||
                b.Categoria.Nome.Contains(termo) || b.Personagem.Nome.Contains(termo)))
            .Select(b => new { b.Nome, Marca = b.Marca.Nome, Categoria = b.Categoria.Nome })
            .Take(20).ToListAsync();

        var sugestoes = new List<string>();
        foreach (var item in query)
        {
            if (item.Nome.Contains(termo, StringComparison.OrdinalIgnoreCase)) sugestoes.Add(item.Nome);
            if (item.Marca.Contains(termo, StringComparison.OrdinalIgnoreCase)) sugestoes.Add(item.Marca);
            if (item.Categoria.Contains(termo, StringComparison.OrdinalIgnoreCase)) sugestoes.Add(item.Categoria);
        }
        return Json(sugestoes.Distinct().Take(6));
    }

    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}