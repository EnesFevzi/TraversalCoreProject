using Microsoft.AspNetCore.Mvc;
using TraversalProject.DataAccessLayer.Concrete;

namespace TraversalProject.WebUI.Areas.Admin.ViewComponents.AdminDashboard
{
    public class _Cards1Statistic : ViewComponent
    {
        private readonly TContext _context;

        public _Cards1Statistic(TContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _context.Destinations.Count();
            ViewBag.v2 = _context.Users.Count();
            return View();
        }
    }
}
