using FabricaDeSorrisos.Application.Abstractions.Repositories;
using FabricaDeSorrisos.Domain.Entities;
using FabricaDeSorrisos.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FabricaDeSorrisos.Infrastructure.Repositories;

public class EfFaixaEtariaRepository : IFaixaEtariaRepository
{
    private readonly AppDbContext _context;

    public EfFaixaEtariaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<FaixaEtaria>> GetAllAsync()
    {
        return await _context.FaixasEtarias
            .OrderBy(f => f.Id) // Geralmente ordenamos por ID ou lógica de idade
            .ToListAsync();
    }

    public async Task<FaixaEtaria?> GetByIdAsync(int id)
    {
        return await _context.FaixasEtarias.FindAsync(id);
    }

    public async Task AddAsync(FaixaEtaria faixa)
    {
        _context.FaixasEtarias.Add(faixa);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(FaixaEtaria faixa)
    {
        _context.FaixasEtarias.Update(faixa);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(FaixaEtaria faixa)
    {
        _context.FaixasEtarias.Remove(faixa);
        await _context.SaveChangesAsync();
    }
}
