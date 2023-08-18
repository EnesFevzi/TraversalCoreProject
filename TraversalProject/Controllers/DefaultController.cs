using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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
