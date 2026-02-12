using FabricaDeSorrisos.Domain.Entities;

using FabricaDeSorrisos.Infrastructure.Identity;

using FabricaDeSorrisos.Infrastructure.Persistence; // Para acessar o banco e salvar o Usuario

using FabricaDeSorrisos.Web.Models;

using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

namespace FabricaDeSorrisos.Web.Controllers;

public class AccountController : Controller

{

    private readonly UserManager<ApplicationUser> _userManager;

    private readonly SignInManager<ApplicationUser> _signInManager;

    private readonly AppDbContext _context; // Precisamos do contexto para salvar na tabela UsuariosDoSistema

    public AccountController(

        UserManager<ApplicationUser> userManager,

        SignInManager<ApplicationUser> signInManager,

        AppDbContext context)

    {

        _userManager = userManager;

        _signInManager = signInManager;

        _context = context;

    }

    // --- LOGIN ---

    [HttpGet]

    public IActionResult Login() => View();

    [HttpPost]

    public async Task<IActionResult> Login(LoginViewModel model)

    {

        if (!ModelState.IsValid) return View(model);

        var result = await _signInManager.PasswordSignInAsync(model.Email, model.Senha, model.LembrarMe, false);

        if (result.Succeeded)

        {

            // Se for Admin, manda pro Dashboard. Se for Cliente, manda pra Home.

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (await _userManager.IsInRoleAsync(user, "Admin"))

            {

                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });

            }

            return RedirectToAction("Index", "Home");

        }

        ModelState.AddModelError(string.Empty, "Login inválido. Verifique e-mail e senha.");

        return View(model);

    }

    // --- REGISTRO (CRIAR CONTA) ---

    [HttpGet]

    public IActionResult Register() => View();

    [HttpPost]

    public async Task<IActionResult> Register(RegisterViewModel model)

    {

        if (!ModelState.IsValid) return View(model);

        // 1. Cria o usuário no Identity (Login/Senha)

        var user = new ApplicationUser { UserName = model.Email, Email = model.Email };

        var result = await _userManager.CreateAsync(user, model.Senha);

        if (result.Succeeded)

        {

            // 2. Define o papel como "Cliente"

            await _userManager.AddToRoleAsync(user, "Cliente");

            // 3. Cria o registro na tabela de Domínio (UsuariosDoSistema)

            var tipoCliente = await _context.TiposUsuarios.FirstOrDefaultAsync(t => t.Nome == "Cliente");

            if (tipoCliente != null)

            {

                var usuarioSistema = new Usuario

                {

                    NomeCompleto = model.NomeCompleto,

                    Email = model.Email,

                    Cpf = "00000000000", // CPF provisório ou pedir no form

                    IdentityUserId = user.Id,

                    TipoUsuarioId = tipoCliente.Id

                };

                _context.UsuariosDoSistema.Add(usuarioSistema);

                await _context.SaveChangesAsync();

            }

            // 4. Loga o usuário imediatamente

            await _signInManager.SignInAsync(user, isPersistent: false);

            return RedirectToAction("Index", "Home");

        }

        foreach (var error in result.Errors)

        {

            ModelState.AddModelError(string.Empty, error.Description);

        }

        return View(model);

    }

    // --- LOGOUT ---

    [HttpPost]

    public async Task<IActionResult> Logout()

    {

        await _signInManager.SignOutAsync();

        return RedirectToAction("Index", "Home");

    }

    // Página de Acesso Negado (Opcional, mas boa prática)

    [HttpGet]

    public IActionResult AccessDenied()

    {

        return View();

    }

}
