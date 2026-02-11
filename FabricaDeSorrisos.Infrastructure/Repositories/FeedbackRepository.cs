using FabricaDeSorrisos.Application.Abstractions.Repositories;
using FabricaDeSorrisos.Domain.Entities;
using FabricaDeSorrisos.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FabricaDeSorrisos.Infrastructure.Repositories;

public class FeedbackRepository : IFeedbackRepository
{
    private readonly AppDbContext _context;

    public FeedbackRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddComentarioAsync(Comentario comentario)
    {
        _context.Comentarios.Add(comentario);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Comentario>> GetComentariosByBrinquedoIdAsync(int brinquedoId)
    {
        return await _context.Comentarios
            .Include(c => c.Usuario) // Traz o nome do usuário
            .Where(c => c.BrinquedoId == brinquedoId)
            .OrderByDescending(c => c.DataComentario)
            .ToListAsync();
    }

    public async Task AddAvaliacaoAsync(Avaliacao avaliacao)
    {
        _context.Avaliacoes.Add(avaliacao);
        await _context.SaveChangesAsync();
    }

    public async Task<double> GetMediaAvaliacaoAsync(int brinquedoId)
    {
        var notas = await _context.Avaliacoes
            .Where(a => a.BrinquedoId == brinquedoId)
            .Select(a => a.Nota)
            .ToListAsync();

        if (!notas.Any()) return 0;
        return notas.Average();
    }

    public async Task<int> GetQuantidadeAvaliacoesAsync(int brinquedoId)
    {
        return await _context.Avaliacoes.CountAsync(a => a.BrinquedoId == brinquedoId);
    }

    public async Task<bool> UsuarioJaAvaliouAsync(int usuarioId, int brinquedoId)
    {
        return await _context.Avaliacoes.AnyAsync(a => a.UsuarioId == usuarioId && a.BrinquedoId == brinquedoId);
    }
}