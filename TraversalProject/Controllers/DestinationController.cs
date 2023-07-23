using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.BusinessLayer.Concrete;
using TraversalProject.DtoLayer.Dtos.DestinationDto;
using TraversalProject.DtoLayer.Dtos.TestimonialDto;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.WebUI.Controllers
{
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
    }
}
