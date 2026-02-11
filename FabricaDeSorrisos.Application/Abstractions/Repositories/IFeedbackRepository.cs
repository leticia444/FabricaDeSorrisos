using FabricaDeSorrisos.Domain.Entities;

namespace FabricaDeSorrisos.Application.Abstractions.Repositories;

public interface IFeedbackRepository
{
    // Comentários
    Task AddComentarioAsync(Comentario comentario);
    Task<List<Comentario>> GetComentariosByBrinquedoIdAsync(int brinquedoId);

    // Avaliações
    Task AddAvaliacaoAsync(Avaliacao avaliacao);
    Task<double> GetMediaAvaliacaoAsync(int brinquedoId);
    Task<int> GetQuantidadeAvaliacoesAsync(int brinquedoId);

    // Verifica se usuário já avaliou este produto (para não avaliar 2x)
    Task<bool> UsuarioJaAvaliouAsync(int usuarioId, int brinquedoId);
}
