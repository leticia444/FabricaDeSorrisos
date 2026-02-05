using FabricaDeSorrisos.Web.Models;

namespace FabricaDeSorrisos.Web.Services;

public interface ICatalogService
{
    // Busca a página principal (Produtos + Listas de Filtros)
    Task<CatalogViewModel> GetCatalogHomeAsync(int page, string? termo, int? marcaId, int? catId, int? subId, int? faixaId, int? persId);

    // Busca os detalhes de um único brinquedo
    Task<BrinquedoDto?> GetBrinquedoDetalhesAsync(int id);
}
