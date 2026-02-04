using FabricaDeSorrisos.Application.Abstractions.Services;
using Microsoft.AspNetCore.Mvc;

namespace FabricaDeSorrisos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PersonagensController : ControllerBase
{
    private readonly ICatalogLookupService _service;

    public PersonagensController(ICatalogLookupService service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok(await _service.GetPersonagensAsync());
    }
}
