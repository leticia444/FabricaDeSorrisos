using FabricaDeSorrisos.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FabricaDeSorrisos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var usuarios = await _context.UsuariosDoSistema
                .Include(u => u.TipoUsuario)
                .Select(u => new
                {
                    Id = u.Id,
                    Nome = u.NomeCompleto,
                    Email = u.Email,
                    TipoUsuario = u.TipoUsuario != null
                        ? u.TipoUsuario.Nome
                        : string.Empty
                })
                .ToListAsync();

            return Ok(usuarios);
        }
    }
}
