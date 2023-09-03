using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;

namespace TraversalProject.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index2()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }
    }
}
