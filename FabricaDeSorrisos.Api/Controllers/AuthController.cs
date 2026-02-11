using FabricaDeSorrisos.Api.Models.Auth;
using FabricaDeSorrisos.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FabricaDeSorrisos.Api.Controllers.Auth
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly JwtTokenService _jwtTokenService;

        public AuthController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            JwtTokenService jwtTokenService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _jwtTokenService = jwtTokenService;
        }

        // =========================
        // REGISTER
        // =========================
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            var userExists = await _userManager.FindByEmailAsync(request.Email);
            if (userExists != null)
                return BadRequest("Usuário já existe");

            var user = new ApplicationUser
            {
                UserName = request.Email,
                Email = request.Email,
                NomeCompleto = request.Nome
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
                return BadRequest(result.Errors);

            // se veio role da UI, atribui
            if (!string.IsNullOrWhiteSpace(request.Role))
            {
                // cria a role se não existir
                if (!await _roleManager.RoleExistsAsync(request.Role))
                    await _roleManager.CreateAsync(new IdentityRole(request.Role));

                await _userManager.AddToRoleAsync(user, request.Role);
            }

            return Ok("Usuário criado com sucesso");
        }

        // =========================
        // LOGIN
        // =========================
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
                return Unauthorized("Usuário não encontrado");

            if (!await _userManager.CheckPasswordAsync(user, request.Password))
                return Unauthorized("Senha inválida");

            var roles = await _userManager.GetRolesAsync(user);
            var role = roles.FirstOrDefault();

            var token = _jwtTokenService.GenerateToken(user, role);

            return Ok(new
            {
                Token = token,
                user.Id,
                user.Email,
                user.UserName,
                Role = role
            });
        }
    }
}
