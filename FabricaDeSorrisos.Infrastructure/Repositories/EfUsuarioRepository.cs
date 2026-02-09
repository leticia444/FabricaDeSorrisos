using FabricaDeSorrisos.Application.Abstractions.Repositories;
using FabricaDeSorrisos.Domain.Entities;
using FabricaDeSorrisos.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FabricaDeSorrisos.Infrastructure.Repositories;

public class EfUsuarioRepository : IUsuarioRepository
{
    private readonly AppDbContext _context;
    public EfUsuarioRepository(AppDbContext context) => _context = context;

    public async Task<List<Usuario>> GetAllAsync()
    {
        return await _context.UsuariosDoSistema
            .Include(u => u.TipoUsuario) // Para mostrar se é Admin ou Cliente
            .OrderBy(u => u.NomeCompleto)
            .ToListAsync();
    }

    public async Task<Usuario?> GetByIdAsync(int id)
    {
        return await _context.UsuariosDoSistema
            .Include(u => u.TipoUsuario)
            .FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task DeleteAsync(Usuario usuario)
    {
        _context.UsuariosDoSistema.Remove(usuario);
        await _context.SaveChangesAsync();
    }
}