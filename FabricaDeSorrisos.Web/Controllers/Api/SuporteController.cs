using FabricaDeSorrisos.Application.Abstractions.Repositories;
using FabricaDeSorrisos.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FabricaDeSorrisos.Web.Controllers.Api;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class SuporteController : ControllerBase
{
    private readonly ISuporteRepository _repo;

    public SuporteController(ISuporteRepository repo)
    {
        _repo = repo;
    }

    // GET: api/Suporte/historico
    [HttpGet("historico")]
    public async Task<IActionResult> GetHistorico()
    {
        var usuarioIdClaim = User.FindFirstValue("UsuarioSistemaId");
        if (string.IsNullOrEmpty(usuarioIdClaim)) return Unauthorized();

        var mensagens = await _repo.GetMensagensDoUsuarioAsync(int.Parse(usuarioIdClaim));
        return Ok(mensagens);
    }

    // POST: api/Suporte/enviar
    [HttpPost("enviar")]
    public async Task<IActionResult> Enviar([FromBody] DtoMensagem envio)
    {
        var usuarioIdClaim = User.FindFirstValue("UsuarioSistemaId");
        if (string.IsNullOrEmpty(usuarioIdClaim)) return Unauthorized();

        var novaMsg = new MensagemSuporte
        {
            Texto = envio.Texto,
            DataEnvio = DateTime.UtcNow,
            UsuarioId = int.Parse(usuarioIdClaim),
            RespondidoPorAdmin = false
        };

        await _repo.SalvarMensagemAsync(novaMsg);
        return Ok(new { success = true });
    }


    // No seu SuporteController.cs dentro de Controllers/Api na WEB
    [Authorize(Roles = "Admin,Gerente")]
    [HttpGet("admin/conversas")]
    public async Task<IActionResult> ListarConversas()
    {
        // Busca todos os IDs de usuários que possuem mensagens
        var usuariosIds = await _repo.GetUsuariosComMensagensPendentesAsync();

        // Aqui você pode implementar uma lógica para retornar nomes de usuários 
        // ou apenas os IDs por enquanto.
        return Ok(usuariosIds);
    }

    // O método Enviar já está pronto, mas lembre-se: 
    // Se o Admin enviar, ele deve passar o DestinatarioId no corpo do JSON.
}

public class DtoMensagem
{
    public string Texto { get; set; }
}
