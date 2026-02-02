namespace FabricaDeSorrisos.Domain.Entities;

public class Categoria
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public ICollection<Brinquedo>? Brinquedos { get; set; }
}
