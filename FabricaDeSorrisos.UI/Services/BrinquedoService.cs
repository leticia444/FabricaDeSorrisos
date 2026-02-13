using FabricaDeSorrisos.UI.Api;
using FabricaDeSorrisos.UI.ViewModels.Brinquedos;
using System.Net.Http.Json;

namespace FabricaDeSorrisos.UI.Models.Services
{
    public class BrinquedoService
    {
        private readonly HttpClient _client;

        public BrinquedoService()
        {
            _client = ApiClient.GetClient();
        }

        public async Task<PagedResult<BrinquedoViewModel>> ListarAsync(int pageIndex = 1, int pageSize = 50, string? termo = null)
        {
            var url = $"brinquedos?pageIndex={pageIndex}&pageSize={pageSize}";
            if (!string.IsNullOrWhiteSpace(termo))
                url += $"&termoBusca={Uri.EscapeDataString(termo)}";

            var result = await _client.GetFromJsonAsync<PagedResult<BrinquedoViewModel>>(url);
            return result ?? new PagedResult<BrinquedoViewModel>
            {
                Items = new List<BrinquedoViewModel>(),
                TotalCount = 0,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
        }
    }
}
