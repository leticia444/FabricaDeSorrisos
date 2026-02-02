using Microsoft.AspNetCore.Mvc;

namespace FabricaDeSorrisos.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    // Placeholder para a página de suporte (Chat)
    public IActionResult Suporte()
    {
        return View();
    }
}