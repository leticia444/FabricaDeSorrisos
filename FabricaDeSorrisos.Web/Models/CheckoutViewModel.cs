using FabricaDeSorrisos.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace FabricaDeSorrisos.Web.Models;

public class CheckoutViewModel
{
    public List<CarrinhoItem> Itens { get; set; } = new();

    // Cálculos
    public decimal Subtotal => Itens.Sum(i => i.Quantidade * i.Brinquedo.Preco);
    public decimal ValorFrete { get; set; }
    public decimal Total => Subtotal + ValorFrete;

    // Campos do Formulário
    [Required(ErrorMessage = "O CEP é obrigatório")]
    public string CEP { get; set; }

    [Required(ErrorMessage = "O endereço é obrigatório")]
    public string Endereco { get; set; }

    [Required(ErrorMessage = "Escolha uma forma de pagamento")]
    public string FormaPagamento { get; set; } // "Pix", "Cartao", "Boleto"
}