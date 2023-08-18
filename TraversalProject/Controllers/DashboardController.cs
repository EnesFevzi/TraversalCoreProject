using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
