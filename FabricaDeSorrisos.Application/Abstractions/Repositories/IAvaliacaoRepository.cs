using FabricaDeSorrisos.Domain.Entities;

namespace FabricaDeSorrisos.Application.Abstractions.Repositories;

public interface IAvaliacaoRepository
{
    // Busca todas as avaliações de um brinquedo específico
    Task<List<Avaliacao>> GetByBrinquedoIdAsync(int brinquedoId);

    // Adicionar uma avaliação (o usuário não costuma editar/deletar em sistemas simples, mas pode)
    Task AddAsync(Avaliacao avaliacao);
}
