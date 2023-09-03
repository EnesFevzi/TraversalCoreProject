using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.WebUI.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
    }
}
