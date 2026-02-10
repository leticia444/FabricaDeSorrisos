using FabricaDeSorrisos.Application.Abstractions.Repositories;
using FabricaDeSorrisos.Domain.Entities;
using FabricaDeSorrisos.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FabricaDeSorrisos.Infrastructure.Repositories;

public class EfPedidoRepository : IPedidoRepository
{
    private readonly AppDbContext _context;

    public EfPedidoRepository(AppDbContext context) => _context = context;

    public async Task AddAsync(Pedido pedido)
    {
        _context.Pedidos.Add(pedido);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Pedido>> GetPedidosDoUsuarioAsync(int usuarioId)
    {
        return await _context.Pedidos
            .Include(p => p.Itens)
            .ThenInclude(i => i.Brinquedo) // Traz os detalhes do brinquedo
            .Where(p => p.UsuarioId == usuarioId)
            .OrderByDescending(p => p.DataPedido)
            .ToListAsync();
    }

    public async Task<Pedido?> GetPedidoPorIdAsync(int id)
    {
        return await _context.Pedidos
           .Include(p => p.Itens)
           .ThenInclude(i => i.Brinquedo)
           .FirstOrDefaultAsync(p => p.Id == id);
    }
}
