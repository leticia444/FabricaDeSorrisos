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
        private readonly JwtTokenService _jwtTokenService;

        public AuthController(
            UserManager<ApplicationUser> userManager,
            JwtTokenService jwtTokenService)
        {
            _userManager = userManager;
            _jwtTokenService = jwtTokenService;
        }

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

            if (role == null)
                return Unauthorized("Usuário sem role");

            // 🔑 GERA O JWT AQUI
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