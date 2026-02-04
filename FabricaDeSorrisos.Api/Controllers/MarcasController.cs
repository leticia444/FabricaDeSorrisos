using FabricaDeSorrisos.Application.Abstractions.Services;
using Microsoft.AspNetCore.Mvc;

namespace FabricaDeSorrisos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MarcasController : ControllerBase
{
    private readonly ICatalogLookupService _service;

    public MarcasController(ICatalogLookupService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _service.GetMarcasAsync();
        return Ok(result);
    }
}
