using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.BusinessLayer.Concrete;
using TraversalProject.DtoLayer.Dtos.DestinationDto;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public DestinationController(IDestinationService destinationService, IMapper mapper, UserManager<AppUser> userManager)
        {
            _destinationService = destinationService;
            _mapper = mapper;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            var listDestinationDto = _mapper.Map<List<ListDestinationDto>>(values);
            return View(listDestinationDto);
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(AddDestinationDto destinationDto)
        {
            var destination = _mapper.Map<Destination>(destinationDto);
            _destinationService.TAdd(destination);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(int id)
        {
            var values = _destinationService.TGetByID(id);
            _destinationService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.TGetByID(id);
            var destinationDto = _mapper.Map<UpdateDestinationDto>(values);
            return View(destinationDto);
        }

        [HttpPost]
        public IActionResult UpdateDestination(UpdateDestinationDto destinationDto)
        {
            if (ModelState.IsValid)
            {
                var destination = _mapper.Map<Destination>(destinationDto);
                _destinationService.TUpdate(destination);
                return RedirectToAction("Index");
            }

            return View(destinationDto); // Eğer ModelState geçerli değilse, hata mesajları ile birlikte View'i tekrar göster
        }
    }
}
