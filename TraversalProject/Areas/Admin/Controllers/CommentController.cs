using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.WebUI.Areas.Admin.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
