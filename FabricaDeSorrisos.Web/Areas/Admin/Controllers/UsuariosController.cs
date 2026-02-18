using FabricaDeSorrisos.Application.Abstractions.Repositories;
using FabricaDeSorrisos.Domain.Entities;
using FabricaDeSorrisos.Infrastructure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace FabricaDeSorrisos.Web.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
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

    // CREATE (GET)
    public async Task<IActionResult> Create()
    {
        ViewBag.Tipos = new SelectList(await _repository.GetTiposUsuariosAsync(), "Id", "Nome");
        return View(new UsuarioFormViewModel());
    }

    // CREATE (POST)
    [HttpPost]
    public async Task<IActionResult> Create(UsuarioFormViewModel model)
    {
        if (ModelState.IsValid)
        {
            // 1. Cria no Identity (Login)
            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Senha);

            if (result.Succeeded)
            {
                // Define Role baseada no Tipo
                var tipos = await _repository.GetTiposUsuariosAsync();
                var tipoEscolhido = tipos.FirstOrDefault(t => t.Id == model.TipoUsuarioId);

                if (tipoEscolhido?.Nome == "Administrador") await _userManager.AddToRoleAsync(user, "Admin");
                else if (tipoEscolhido?.Nome == "Gerente") await _userManager.AddToRoleAsync(user, "Gerente");
                else await _userManager.AddToRoleAsync(user, "Cliente");

                // 2. Cria na Tabela de Negócio (Usuario)
                var novoUsuario = new Usuario
                {
                    NomeCompleto = model.NomeCompleto,
                    Email = model.Email,
                    TipoUsuarioId = model.TipoUsuarioId,
                    IdentityUserId = user.Id,
                    Cpf = model.Cpf ?? "",
                };

                await _repository.AddAsync(novoUsuario);
                return RedirectToAction(nameof(Index));
            }

            // --- LÓGICA DO MODAL DE ERRO DE SENHA (TRADUZIDO) ---
            var errosSenha = result.Errors
                .Where(e => e.Code.StartsWith("Password"))
                .Select(e => TraduzirErro(e.Code)) // Chama a função de tradução
                .ToList();

            if (errosSenha.Any())
            {
                ViewBag.ErrosSenha = errosSenha;
            }

            foreach (var error in result.Errors)
            {
                if (!error.Code.StartsWith("Password"))
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
        }

        ViewBag.Tipos = new SelectList(await _repository.GetTiposUsuariosAsync(), "Id", "Nome", model.TipoUsuarioId);
        return View(model);
    }

    // Função auxiliar para traduzir as mensagens do inglês
    private string TraduzirErro(string code)
    {
        return code switch
        {
            "PasswordTooShort" => "A senha é muito curta. Ela deve ter no mínimo 6 caracteres.",
            "PasswordRequiresNonAlphanumeric" => "Adicione pelo menos um caractere especial (ex: @, #, !, $).",
            "PasswordRequiresDigit" => "Adicione pelo menos um número (0-9).",
            "PasswordRequiresUpper" => "Adicione pelo menos uma letra MAIÚSCULA ('A'-'Z').",
            "PasswordRequiresLower" => "Adicione pelo menos uma letra minúscula ('a'-'z').",
            "PasswordRequiresUniqueChars" => "A senha precisa ter caracteres diferentes entre si.",
            _ => "A senha não atende aos requisitos de segurança."
        };
    }

    // EDIT (GET)
    public async Task<IActionResult> Edit(int id)
    {
        var usuario = await _repository.GetByIdAsync(id);
        if (usuario == null) return NotFound();

        var model = new UsuarioFormViewModel
        {
            Id = usuario.Id,
            NomeCompleto = usuario.NomeCompleto,
            Email = usuario.Email,
            TipoUsuarioId = usuario.TipoUsuarioId,
            Cpf = usuario.Cpf
        };

        ViewBag.Tipos = new SelectList(await _repository.GetTiposUsuariosAsync(), "Id", "Nome", usuario.TipoUsuarioId);
        return View(model);
    }

    // EDIT (POST)
    [HttpPost]
    public async Task<IActionResult> Edit(int id, UsuarioFormViewModel model)
    {
        if (ModelState.IsValid)
        {
            var usuario = await _repository.GetByIdAsync(id);
            if (usuario == null) return NotFound();

            // Atualiza dados locais
            usuario.NomeCompleto = model.NomeCompleto;
            usuario.TipoUsuarioId = model.TipoUsuarioId;
            usuario.Cpf = model.Cpf;

            await _repository.UpdateAsync(usuario);
            return RedirectToAction(nameof(Index));
        }

        ViewBag.Tipos = new SelectList(await _repository.GetTiposUsuariosAsync(), "Id", "Nome", model.TipoUsuarioId);
        return View(model);
    }

    // DELETE
    public async Task<IActionResult> Delete(int id)
    {
        var usuario = await _repository.GetByIdAsync(id);
        if (usuario == null) return NotFound();
        return View(usuario);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var usuarioDomain = await _repository.GetByIdAsync(id);
        if (usuarioDomain != null)
        {
            var usuarioIdentity = await _userManager.FindByIdAsync(usuarioDomain.IdentityUserId);
            await _repository.DeleteAsync(usuarioDomain);
            if (usuarioIdentity != null) await _userManager.DeleteAsync(usuarioIdentity);
        }
        return RedirectToAction(nameof(Index));
    }
}

// ViewModel Auxiliar
public class UsuarioFormViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    public string NomeCompleto { get; set; }

    [Required(ErrorMessage = "O email é obrigatório")]
    [EmailAddress]
    public string Email { get; set; }

    public string? Senha { get; set; }

    public string? Cpf { get; set; }

    [Required(ErrorMessage = "Selecione um tipo de perfil")]
    public int TipoUsuarioId { get; set; }
}