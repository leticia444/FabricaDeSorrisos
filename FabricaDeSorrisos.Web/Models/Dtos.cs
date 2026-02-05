namespace FabricaDeSorrisos.Web.Models;

// Representa um brinquedo na vitrine
public class BrinquedoDto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public string? ImagemUrl { get; set; }
    public int Estoque { get; set; }

    // Dados achatados (Texto direto)
    public string Categoria { get; set; } = string.Empty;
    public string SubCategoria { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public string FaixaEtaria { get; set; } = string.Empty;
    public string? Personagem { get; set; }
}

// Representa o resultado da paginação (Ex: Página 1 de 10)
public class PagedResult<T>
{
    public List<T> Items { get; set; } = new();
    public int TotalCount { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public int TotalPages { get; set; }
}

// DTOs auxiliares para os filtros (Menus laterais)
public class MarcaDto { public int Id { get; set; } public string Nome { get; set; } = string.Empty; }
public class CategoriaDto { public int Id { get; set; } public string Nome { get; set; } = string.Empty; public List<SubCategoriaDto> SubCategorias { get; set; } = new(); }
public class SubCategoriaDto { public int Id { get; set; } public string Nome { get; set; } = string.Empty; }
public class FaixaEtariaDto { public int Id { get; set; } public string Descricao { get; set; } = string.Empty; }
public class PersonagemDto { public int Id { get; set; } public string Nome { get; set; } = string.Empty; }
