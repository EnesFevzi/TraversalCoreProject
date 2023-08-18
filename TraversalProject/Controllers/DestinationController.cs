using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.BusinessLayer.Concrete;
using TraversalProject.DtoLayer.Dtos.DestinationDto;
using TraversalProject.DtoLayer.Dtos.TestimonialDto;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.WebUI.Controllers
{
    [Authorize]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IMapper _mapper;

        public DestinationController(IDestinationService destinationService, UserManager<AppUser> userManager, IMapper mapper)
        {
            _destinationService = destinationService;
            _userManager = userManager;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            var destinationDtos = _mapper.Map<List<ListDestinationDto>>(values);
            return View(destinationDtos);
        }
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.i = id;
            ViewBag.destID = id;
            //var value = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.userID = value.Id;
            var values = _destinationService.TGetDestinationWithGuide(id);
            return View(values);
        }
    }
}
