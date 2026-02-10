using FabricaDeSorrisos.Application.Abstractions.Repositories;
using FabricaDeSorrisos.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FabricaDeSorrisos.Web.Controllers.Api;

[Route("api/[controller]")]
[ApiController]
[Authorize] // Só aceita quem tem o Cookie de login
public class FavoritosController : ControllerBase
{
    private readonly IFavoritoRepository _favoritoRepo;
    private readonly IBrinquedoRepository _brinquedoRepo;

    public FavoritosController(IFavoritoRepository favoritoRepo, IBrinquedoRepository brinquedoRepo)
    {
        _favoritoRepo = favoritoRepo;
        _brinquedoRepo = brinquedoRepo;
    }

    [HttpPost("toggle/{brinquedoId}")]
    public async Task<IActionResult> Toggle(int brinquedoId)
    {
        // 1. Pega o ID que gravamos no Cookie (Claims)
        var usuarioIdClaim = User.FindFirstValue("UsuarioSistemaId");

        if (string.IsNullOrEmpty(usuarioIdClaim))
            return BadRequest(new { success = false, message = "Erro ao identificar usuário." });

        int usuarioId = int.Parse(usuarioIdClaim);

        // 2. Verifica se o brinquedo existe
        if (!await _brinquedoRepo.ExistsAsync(brinquedoId))
            return NotFound(new { success = false, message = "Brinquedo não encontrado." });

        // 3. Lógica do Toggle (Se tem, tira. Se não tem, põe)
        var favoritoExistente = await _favoritoRepo.GetByUsuarioEBrinquedoAsync(usuarioId, brinquedoId);

        if (favoritoExistente != null)
        {
            await _favoritoRepo.DeleteAsync(favoritoExistente);
            return Ok(new { success = true, action = "removed", message = "Removido dos favoritos!" });
        }
        else
        {
            var novoFavorito = new Favorito
            {
                UsuarioId = usuarioId,
                BrinquedoId = brinquedoId,
                DataFavoritado = DateTime.Now
            };
            await _favoritoRepo.AddAsync(novoFavorito);
            return Ok(new { success = true, action = "added", message = "Adicionado aos favoritos!" });
        }
    }
}