using FabricaDeSorrisos.Application.Abstractions.Repositories;
using FabricaDeSorrisos.Infrastructure.Identity; // Necessário para ApplicationUser
using FabricaDeSorrisos.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore; // Necessário para o .CountAsync()

namespace FabricaDeSorrisos.Web.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public class DashboardController : Controller
{
    private readonly IBrinquedoRepository _brinquedoRepo;
    private readonly IPedidoRepository _pedidoRepo;
    private readonly UserManager<ApplicationUser> _userManager;

    public DashboardController(
        IBrinquedoRepository brinquedoRepo,
        IPedidoRepository pedidoRepo,
        UserManager<ApplicationUser> userManager)
    {
        _brinquedoRepo = brinquedoRepo;
        _pedidoRepo = pedidoRepo;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        // 1. Busca os dados
        // Nota: O ideal seria ter métodos "Count" nos repositórios para performance,
        // mas usar o GetAll e contar funciona bem para este estágio do projeto.

        var brinquedos = await _brinquedoRepo.GetAllAsync();
        var pedidos = await _pedidoRepo.GetTodosPedidosAsync();

        // Contando usuários direto do Identity
        var qtdUsuarios = await _userManager.Users.CountAsync();

        // 2. Monta a ViewModel
        var viewModel = new DashboardViewModel
        {
            QtdBrinquedos = brinquedos.Count,

            QtdUsuarios = qtdUsuarios,

            QtdPedidos = pedidos.Count,

            // Soma o total de todos os pedidos que NÃO foram cancelados (se houver essa lógica)
            // Aqui estamos somando tudo para simplificar
            FaturamentoTotal = pedidos.Sum(p => p.ValorTotal)
        };

        return View(viewModel);
    }
}
