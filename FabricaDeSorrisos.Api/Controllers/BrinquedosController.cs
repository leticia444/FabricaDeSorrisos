using FabricaDeSorrisos.Application.Abstractions.Services;
using FabricaDeSorrisos.Application.Filters;
using Microsoft.AspNetCore.Mvc;

namespace FabricaDeSorrisos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BrinquedosController : ControllerBase
{
    private readonly IBrinquedoQueryService _queryService;

    public BrinquedosController(IBrinquedoQueryService queryService)
    {
        _queryService = queryService;
    }

    // GET: api/brinquedos?pageIndex=1&termoBusca=lego&marcaId=2...
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] BrinquedoFilter filter)
    {
        var result = await _queryService.GetAllAsync(filter);
        return Ok(result);
    }

    // GET: api/brinquedos/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var brinquedo = await _queryService.GetDetalhesByIdAsync(id);
        if (brinquedo == null) return NotFound();
        return Ok(brinquedo);
    }

    // GET: api/brinquedos/sugestoes?termo=bat
    [HttpGet("sugestoes")]
    public async Task<IActionResult> GetSugestoes([FromQuery] string termo)
    {
        if (string.IsNullOrWhiteSpace(termo) || termo.Length < 2)
            return Ok(new List<string>());

        var sugestoes = await _queryService.GetSugestoesNomesAsync(termo);
        return Ok(sugestoes);
    }
}