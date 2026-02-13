using FabricaDeSorrisos.Application.Abstractions.Repositories;
using FabricaDeSorrisos.Domain.Entities;
using FabricaDeSorrisos.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FabricaDeSorrisos.Infrastructure.Repositories;

public class SuporteRepository : ISuporteRepository
{
    private readonly AppDbContext _context;

    public SuporteRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<MensagemSuporte>> GetMensagensDoUsuarioAsync(int usuarioId)
    {
        return await _context.MensagensSuporte
            .Where(m => m.UsuarioId == usuarioId)
            .OrderBy(m => m.DataEnvio)
            .ToListAsync();
    }

    public async Task<List<int>> GetUsuariosComMensagensPendentesAsync()
    {
        // Retorna IDs de usuários que mandaram msg e ainda não foi respondida pelo admin
        return await _context.MensagensSuporte
            .Where(m => !m.RespondidoPorAdmin)
            .Select(m => m.UsuarioId)
            .Distinct()
            .ToListAsync();
    }

    public async Task SalvarMensagemAsync(MensagemSuporte mensagem)
    {
        _context.MensagensSuporte.Add(mensagem);
        await _context.SaveChangesAsync();
    }

    public async Task MarcarComoRespondidaAsync(int usuarioId)
    {
        // Lógica futura se quiser marcar visualização
    }
}