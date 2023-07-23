using Microsoft.AspNetCore.Mvc;
using TraversalProject.DataAccessLayer.Concrete;

namespace TraversalProject.WebUI.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        private readonly TContext _context;

        public _Statistics(TContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _context.Destinations.Count();
            ViewBag.v2 = _context.Guides.Count();
            ViewBag.v3 = "285";
            return View();
        }
    }
}
