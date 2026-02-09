using FabricaDeSorrisos.Domain.Entities;

namespace FabricaDeSorrisos.Application.Abstractions.Repositories;

public interface IUsuarioRepository
{
    Task<List<Usuario>> GetAllAsync();
    Task<Usuario?> GetByIdAsync(int id);
    Task DeleteAsync(Usuario usuario);
    // Não vamos fazer Add/Update aqui por enquanto, pois isso envolve Senha/Identity
}