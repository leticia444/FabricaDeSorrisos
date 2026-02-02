var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte para MVC (Model-View-Controller)
builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Permite carregar CSS e imagens da pasta wwwroot

app.UseRouting();

app.UseAuthorization();

// Define a rota padrão: Home -> Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();