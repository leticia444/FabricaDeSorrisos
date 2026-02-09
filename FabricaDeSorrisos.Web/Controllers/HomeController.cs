using FabricaDeSorrisos.Application.Abstractions.Repositories; // Acesso aos Repositórios
using FabricaDeSorrisos.Application.DTOs;
using FabricaDeSorrisos.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FabricaDeSorrisos.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    // Injetamos os repositórios para acessar o banco direto
    private readonly IBrinquedoRepository _brinquedoRepo;
    private readonly IMarcaRepository _marcaRepo;
    private readonly ICategoriaRepository _categoriaRepo;
    private readonly IFaixaEtariaRepository _faixaRepo;
    private readonly IPersonagemRepository _personagemRepo;

    public HomeController(
        ILogger<HomeController> logger,
        IBrinquedoRepository brinquedoRepo,
        IMarcaRepository marcaRepo,
        ICategoriaRepository categoriaRepo,
        IFaixaEtariaRepository faixaRepo,
        IPersonagemRepository personagemRepo)
    {
        _logger = logger;
        _brinquedoRepo = brinquedoRepo;
        _marcaRepo = marcaRepo;
        _categoriaRepo = categoriaRepo;
        _faixaRepo = faixaRepo;
        _personagemRepo = personagemRepo;
    }

    // Ação Principal: Carrega a vitrine
    public async Task<IActionResult> Index(
        int pageIndex = 1,
        string? termoBusca = null,
        int? marcaId = null,
        int? categoriaId = null,
        int? subCategoriaId = null,
        int? faixaEtariaId = null,
        int? personagemId = null)
    {
        // 1. Buscar todos os dados do banco
        var todosBrinquedos = await _brinquedoRepo.GetAllAsync();

        // 2. Aplicar Filtros (Lógica feita em memória agora)
        // Começamos com todos que estão ATIVOS
        var query = todosBrinquedos.Where(b => b.Ativo).AsEnumerable();

        if (!string.IsNullOrEmpty(termoBusca))
        {
            query = query.Where(b => b.Nome.Contains(termoBusca, StringComparison.OrdinalIgnoreCase)
                                  || b.Descricao.Contains(termoBusca, StringComparison.OrdinalIgnoreCase));
        }

        if (marcaId.HasValue) query = query.Where(b => b.MarcaId == marcaId.Value);
        if (categoriaId.HasValue) query = query.Where(b => b.CategoriaId == categoriaId.Value);
        // if (subCategoriaId.HasValue) query = query.Where(b => b.SubCategoriaId == subCategoriaId.Value); // Descomente quando tiver SubCategoria
        if (faixaEtariaId.HasValue) query = query.Where(b => b.FaixaEtariaId == faixaEtariaId.Value);
        if (personagemId.HasValue) query = query.Where(b => b.PersonagemId == personagemId.Value);

        // 3. Paginação Simples
        int pageSize = 12;
        int totalItems = query.Count();
        int totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

        var itensPagina = query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToList();

        // 4. Montar a ViewModel para a Tela
        // Precisamos converter as Entidades do Banco para o DTO que a View espera
        var viewModel = new CatalogViewModel
        {
            // Dados dos Filtros Laterais
            Marcas = (await _marcaRepo.GetAllAsync()).Select(m => new MarcaDto { Id = m.Id, Nome = m.Nome }).ToList(),
            Categorias = (await _categoriaRepo.GetAllAsync()).Select(c => new CategoriaDto { Id = c.Id, Nome = c.Nome }).ToList(),
            FaixasEtarias = (await _faixaRepo.GetAllAsync()).Select(f => new FaixaEtariaDto { Id = f.Id, Descricao = f.Descricao }).ToList(),
            Personagens = (await _personagemRepo.GetAllAsync()).Select(p => new PersonagemDto { Id = p.Id, Nome = p.Nome }).ToList(),

            // Estado atual dos filtros (para manter marcado na tela)
            TermoBusca = termoBusca,
            MarcaId = marcaId,
            CategoriaId = categoriaId,
            SubCategoriaId = subCategoriaId,
            FaixaEtariaId = faixaEtariaId,
            PersonagemId = personagemId,
            PageIndex = pageIndex,

            // Lista de Produtos Mapeada
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
                //TotalPages = totalPages,
                PageIndex = pageIndex,
                PageSize = pageSize
            }
        };

        return View(viewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}