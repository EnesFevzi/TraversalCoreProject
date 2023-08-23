using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.WebUI.Areas.Admin.ViewComponents.AdminDashboard
{
    public class _AdminDashboardHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
