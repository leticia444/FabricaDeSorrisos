using System.Net.Http;
using System.Net.Http.Headers;
using FabricaDeSorrisos.UI.Api;
using FabricaDeSorrisos.UI.Models;

public static class ApiClient
{
    private static HttpClient _client;

    public static HttpClient GetClient()
    {
        if (_client != null)
            return _client;

        var handler = new HttpClientHandler
        {
            // ⚠️ DEV ONLY – aceita certificado local
            ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        };

        _client = new HttpClient(handler)
        {
            BaseAddress = new Uri(ApiSettings.BaseUrl)
        };

        _client.DefaultRequestHeaders.Accept.Clear();
        _client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json")
        );

        return _client;
    }
}
