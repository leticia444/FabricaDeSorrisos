using FabricaDeSorrisos.Application.Abstractions.Repositories;
using FabricaDeSorrisos.Domain.Entities;
using FabricaDeSorrisos.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FabricaDeSorrisos.Web.Controllers;

[Authorize]
public class CarrinhoController : Controller
{
    private readonly ICarrinhoRepository _carrinhoRepo;
    private readonly IPedidoRepository _pedidoRepo;
    private readonly IBrinquedoRepository _brinquedoRepo;

    public CarrinhoController(
        ICarrinhoRepository carrinhoRepo,
        IPedidoRepository pedidoRepo,
        IBrinquedoRepository brinquedoRepo)
    {
        _carrinhoRepo = carrinhoRepo;
        _pedidoRepo = pedidoRepo;
        _brinquedoRepo = brinquedoRepo;
    }

    // --- PARTE 1: CARRINHO ---

    public async Task<IActionResult> Index()
    {
        var usuarioId = GetUsuarioId();
        var itens = await _carrinhoRepo.GetCarrinhoDoUsuarioAsync(usuarioId);

        var viewModel = new CarrinhoViewModel { Itens = itens };
        return View(viewModel);
    }

    [HttpPost]
    public async Task<IActionResult> AtualizarQuantidade(int brinquedoId, int quantidade)
    {
        var usuarioId = GetUsuarioId();
        var item = await _carrinhoRepo.GetItemAsync(usuarioId, brinquedoId);

        if (item != null)
        {
            if (quantidade <= 0)
            {
                await _carrinhoRepo.DeleteAsync(item);
            }
            else
            {
                // Validação de Estoque
                var brinquedo = await _brinquedoRepo.GetByIdAsync(brinquedoId);
                if (brinquedo != null && quantidade > brinquedo.Estoque)
                {
                    item.Quantidade = brinquedo.Estoque;
                    TempData["Aviso"] = $"Estoque máximo atingido para {brinquedo.Nome}.";
                }
                else
                {
                    item.Quantidade = quantidade;
                }
                await _carrinhoRepo.UpdateAsync(item);
            }
        }
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Remover(int itemId)
    {
        var usuarioId = GetUsuarioId();
        var item = await _carrinhoRepo.GetItemAsync(usuarioId, itemId);
        if (item != null) await _carrinhoRepo.DeleteAsync(item);

        return RedirectToAction(nameof(Index));
    }

    // --- PARTE 2: CHECKOUT (PAGAMENTO) ---

    [HttpGet]
    public async Task<IActionResult> Checkout()
    {
        var usuarioId = GetUsuarioId();
        var itens = await _carrinhoRepo.GetCarrinhoDoUsuarioAsync(usuarioId);

        if (!itens.Any()) return RedirectToAction(nameof(Index));

        var viewModel = new CheckoutViewModel
        {
            Itens = itens,
            ValorFrete = 0 // Inicia zerado
        };

        return View(viewModel);
    }

    // Simulação de Cálculo de Frete (API)
    [HttpPost]
    public IActionResult CalcularFrete([FromBody] string cep)
    {
        decimal frete = 0;
        if (string.IsNullOrEmpty(cep) || cep.Length < 8) return BadRequest("CEP inválido");

        // Lógica Fake: Par = barato, Ímpar = caro
        var ultimoDigito = int.Parse(cep.Substring(cep.Length - 1));
        frete = ultimoDigito % 2 == 0 ? 15.00m : 25.50m;

        return Ok(new { valor = frete, prazo = "5 dias úteis" });
    }

    [HttpPost]
    public async Task<IActionResult> ProcessarPedido(CheckoutViewModel model)
    {
        var usuarioId = GetUsuarioId();
        var itensCarrinho = await _carrinhoRepo.GetCarrinhoDoUsuarioAsync(usuarioId);

        if (!itensCarrinho.Any()) return RedirectToAction(nameof(Index));

        // 1. Cria o Pedido
        var pedido = new Pedido
        {
            UsuarioId = usuarioId,
            DataPedido = DateTime.Now,
            Status = "Aguardando Pagamento",
            ValorFrete = model.ValorFrete,
            ValorTotal = itensCarrinho.Sum(i => i.Quantidade * i.Brinquedo.Preco) + model.ValorFrete,
            EnderecoEntrega = model.Endereco,
            CEP = model.CEP,
            FormaPagamento = model.FormaPagamento,
            Itens = new List<PedidoItem>()
        };

        // 2. Transfere Itens e Baixa Estoque
        foreach (var item in itensCarrinho)
        {
            var brinquedo = await _brinquedoRepo.GetByIdAsync(item.BrinquedoId);

            // Validação final de segurança
            if (brinquedo == null || brinquedo.Estoque < item.Quantidade)
            {
                TempData["Erro"] = $"Ops! O produto {item.Brinquedo.Nome} acabou agora.";
                return RedirectToAction(nameof(Index));
            }

            var pedidoItem = new PedidoItem
            {
                BrinquedoId = item.BrinquedoId,
                Quantidade = item.Quantidade,
                PrecoUnitario = item.Brinquedo.Preco
            };
            pedido.Itens.Add(pedidoItem);

            // Baixa estoque
            brinquedo.Estoque -= item.Quantidade;
            await _brinquedoRepo.UpdateAsync(brinquedo);
        }

        // 3. Salva Pedido e Limpa Carrinho
        await _pedidoRepo.AddAsync(pedido);
        await _carrinhoRepo.LimparCarrinhoAsync(usuarioId);

        return RedirectToAction(nameof(PedidoConfirmado), new { id = pedido.Id });
    }

    // --- PARTE 3: SUCESSO ---

    public async Task<IActionResult> PedidoConfirmado(int id)
    {
        var pedido = await _pedidoRepo.GetPedidoPorIdAsync(id);

        if (pedido == null || pedido.UsuarioId != GetUsuarioId())
            return NotFound();

        return View(pedido);
    }

    private int GetUsuarioId()
    {
        var claim = User.FindFirstValue("UsuarioSistemaId");
        return int.Parse(claim ?? "0");
    }
}