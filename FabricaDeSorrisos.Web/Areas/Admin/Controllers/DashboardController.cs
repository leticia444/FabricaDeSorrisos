using Microsoft.AspNetCore.Mvc;

namespace FabricaDeSorrisos.Web.Areas.Admin.Controllers;

[Area("Admin")] // Importante: Diz que esse controller pertence à área Admin
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
