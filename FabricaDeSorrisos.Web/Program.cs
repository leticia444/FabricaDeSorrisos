using FabricaDeSorrisos.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. Adiciona serviços ao container.
builder.Services.AddControllersWithViews();

// --- INÍCIO DA CONFIGURAÇÃO DO CLIENTE DA API ---

// Lê o endereço da API que configuramos no appsettings (http://localhost:5259)
var apiBaseUrl = builder.Configuration["ApiBaseUrl"];

// Registra o CatalogService para usar HttpClient com esse endereço base
builder.Services.AddHttpClient<ICatalogService, CatalogService>(client =>
{
    // Garante que a URL base termine com barra se não tiver
    string url = apiBaseUrl ?? "http://localhost:5259";
    if (!url.EndsWith("/")) url += "/";

    client.BaseAddress = new Uri(url);
});

// --- FIM DA CONFIGURAÇÃO ---

var app = builder.Build();

// 2. Configura o pipeline de requisições HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // O valor default de HSTS é 30 dias.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// --- ADICIONE ISTO (Rota da Área Admin) ---
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");
// ------------------------------------------

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();