using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.BusinessLayer.Concrete;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.DataAccessLayer.Concrete.EntityFramework;

namespace TraversalProject.WebUI.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _Feature(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _featureService.TGetList();
            return View(values);
        }
    }
}
