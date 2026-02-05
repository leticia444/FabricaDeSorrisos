using FabricaDeSorrisos.Web.Models;

namespace FabricaDeSorrisos.Web.Services;

public class CatalogService : ICatalogService
{
    private readonly HttpClient _http;

    public CatalogService(HttpClient http)
    {
        _http = http;
    }

    public async Task<CatalogViewModel> GetCatalogHomeAsync(int page, string? termo, int? marcaId, int? catId, int? subId, int? faixaId, int? persId)
    {
        var vm = new CatalogViewModel();

        // 1. Monta a URL com todos os filtros possíveis
        var query = $"?pageIndex={page}&pageSize=12"; // 12 produtos por página

        if (!string.IsNullOrEmpty(termo)) query += $"&termoBusca={termo}";
        if (marcaId.HasValue) query += $"&marcaId={marcaId}";
        if (catId.HasValue) query += $"&categoriaId={catId}";
        if (subId.HasValue) query += $"&subCategoriaId={subId}";
        if (faixaId.HasValue) query += $"&faixaEtariaId={faixaId}";
        if (persId.HasValue) query += $"&personagemId={persId}";

        // 2. Busca os Produtos na API
        try
        {
            // Tenta pegar os produtos da API
            var result = await _http.GetFromJsonAsync<PagedResult<BrinquedoDto>>($"api/brinquedos{query}");
            vm.Produtos = result;
        }
        catch
        {
            // Se a API estiver desligada, cria uma lista vazia para não quebrar o site
            vm.Produtos = new PagedResult<BrinquedoDto>();
        }

        // 3. Busca os dados para preencher o Menu Lateral (Figma)
        // Precisamos saber quais marcas e categorias existem para desenhar os botões
        try
        {
            vm.Marcas = await _http.GetFromJsonAsync<List<MarcaDto>>("api/marcas") ?? new();
            vm.Categorias = await _http.GetFromJsonAsync<List<CategoriaDto>>("api/categorias") ?? new();
            vm.FaixasEtarias = await _http.GetFromJsonAsync<List<FaixaEtariaDto>>("api/faixasetarias") ?? new();
            vm.Personagens = await _http.GetFromJsonAsync<List<PersonagemDto>>("api/personagens") ?? new();
        }
        catch
        {
            // Ignora erro de conexão nos filtros
        }

        // 4. Guarda o que o usuário escolheu (para manter o filtro ativo na tela)
        vm.PageIndex = page;
        vm.TermoBusca = termo;
        vm.MarcaId = marcaId;
        vm.CategoriaId = catId;
        vm.SubCategoriaId = subId;
        vm.FaixaEtariaId = faixaId;
        vm.PersonagemId = persId;

        return vm;
    }

    public async Task<BrinquedoDto?> GetBrinquedoDetalhesAsync(int id)
    {
        try
        {
            return await _http.GetFromJsonAsync<BrinquedoDto>($"api/brinquedos/{id}");
        }
        catch
        {
            return null;
        }
    }
}
