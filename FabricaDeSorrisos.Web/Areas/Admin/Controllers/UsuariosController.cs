using FabricaDeSorrisos.Application.Abstractions.Repositories;
using FabricaDeSorrisos.Infrastructure.Identity; // Para ApplicationUser
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FabricaDeSorrisos.Web.Areas.Admin.Controllers;

[Area("Admin")]
public class UsuariosController : Controller
{
    private readonly IUsuarioRepository _repository;
    private readonly UserManager<ApplicationUser> _userManager;

    public UsuariosController(IUsuarioRepository repository, UserManager<ApplicationUser> userManager)
    {
        _repository = repository;
        _userManager = userManager;
    }

    // LISTAR
    public async Task<IActionResult> Index()
    {
        var usuarios = await _repository.GetAllAsync();
        return View(usuarios);
    }

    // EXCLUIR (Tela)
    public async Task<IActionResult> Delete(int id)
    {
        var usuario = await _repository.GetByIdAsync(id);
        if (usuario == null) return NotFound();
        return View(usuario);
    }

    // EXCLUIR (Confirmado)
    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        // 1. Busca no seu banco
        var usuarioDomain = await _repository.GetByIdAsync(id);
        if (usuarioDomain != null)
        {
            // 2. Busca no Identity (Login) para apagar a senha também
            var usuarioIdentity = await _userManager.FindByIdAsync(usuarioDomain.IdentityUserId);

            // Apaga do seu banco
            await _repository.DeleteAsync(usuarioDomain);

            // Apaga do Identity (se existir)
            if (usuarioIdentity != null)
            {
                await _userManager.DeleteAsync(usuarioIdentity);
            }
        }
        return RedirectToAction(nameof(Index));
    }
}