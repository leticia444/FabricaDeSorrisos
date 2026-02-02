var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte a Controllers e Swagger (documentação)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configura o Swagger apenas em ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// Endpoint de teste rápido (Smoke Test)
// Quando acessar http://localhost:5xxx/ ele deve responder isso
app.MapGet("/", () => new { name = "FabricaDeSorrisos.Api", status = "ok", version = "1.0.0" });

app.Run();