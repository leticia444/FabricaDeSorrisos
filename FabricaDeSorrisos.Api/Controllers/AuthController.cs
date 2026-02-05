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
        private readonly JwtTokenService _tokenService;

        public AuthController(
            UserManager<ApplicationUser> userManager,
            JwtTokenService tokenService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
                return Unauthorized("Usuário ou senha inválidos");

            var passwordValid =
                await _userManager.CheckPasswordAsync(user, request.Password);

            if (!passwordValid)
                return Unauthorized("Usuário ou senha inválidos");

            var token = await _tokenService.GenerateTokenAsync(user, _userManager);

            return Ok(new
            {
                token
            });
        }
    }
}
