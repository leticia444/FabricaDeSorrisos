namespace FabricaDeSorrisos.Domain.Entities;

public class Pedido
{
    public int Id { get; set; }
    public DateTime DataPedido { get; set; } = DateTime.UtcNow;
    public decimal ValorTotal { get; set; }

    public int UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }

    public ICollection<PedidoItem>? Itens { get; set; }
}
