using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
