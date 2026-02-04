using FabricaDeSorrisos.Domain.Entities;

namespace FabricaDeSorrisos.Application.Abstractions.Repositories;

public interface IFaixaEtariaRepository
{
    Task<List<FaixaEtaria>> GetAllAsync();
    Task<FaixaEtaria?> GetByIdAsync(int id);
    // Faixa Etária geralmente é fixa, mas podemos deixar o CRUD caso precise
    Task AddAsync(FaixaEtaria faixa);
    Task UpdateAsync(FaixaEtaria faixa);
    Task DeleteAsync(FaixaEtaria faixa);
}