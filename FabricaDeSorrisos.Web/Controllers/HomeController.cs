using FabricaDeSorrisos.Web.Models;
using FabricaDeSorrisos.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FabricaDeSorrisos.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICatalogService _catalogService;

    // Injetamos o Serviço que cria a ponte com a API
    public HomeController(ILogger<HomeController> logger, ICatalogService catalogService)
    {
        _logger = logger;
        _catalogService = catalogService;
    }

    // Ação Principal: Carrega a vitrine
    // Exemplo de URL: /Home/Index?termoBusca=lego&pageIndex=2
    public async Task<IActionResult> Index(
        int pageIndex = 1,
        string? termoBusca = null,
        int? marcaId = null,
        int? categoriaId = null,
        int? subCategoriaId = null, // Adicionei a SubCategoria que vimos no Figma
        int? faixaEtariaId = null,
        int? personagemId = null)
    {
        // Chama o serviço passando todos os filtros
        var viewModel = await _catalogService.GetCatalogHomeAsync(
            pageIndex, termoBusca, marcaId, categoriaId, subCategoriaId, faixaEtariaId, personagemId);

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