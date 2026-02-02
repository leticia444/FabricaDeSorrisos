namespace FabricaDeSorrisos.Domain.Entities;

public class Comentario
{
    public int Id { get; set; }
    public string Texto { get; set; } = string.Empty;
    public DateTime DataComentario { get; set; } = DateTime.UtcNow;

    public int BrinquedoId { get; set; }
    public Brinquedo? Brinquedo { get; set; }

    public int UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }
}
