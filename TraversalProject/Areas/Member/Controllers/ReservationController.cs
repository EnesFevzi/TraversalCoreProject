using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.BusinessLayer.Concrete;
using TraversalProject.DtoLayer.Dtos.DestinationDto;
using TraversalProject.DtoLayer.Dtos.ReservationDto;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly IMapper _mapper;
        private readonly IDestinationService _destinationService;
        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IReservationService reservationService, IMapper mapper, IDestinationService destinationService, UserManager<AppUser> userManager)
        {
            _reservationService = reservationService;
            _mapper = mapper;
            _destinationService = destinationService;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentReservation()
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var reservations = _reservationService.GetListWithReservationByAccepted(values.Id);
            var dtoList = _mapper.Map<List<ListReservationDto>>(reservations);
            return View(dtoList);
        }
        public async Task<IActionResult> MyOldReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetListWithReservationByPrevious(values.Id);
            var dtoList = _mapper.Map<List<ListReservationDto>>(valuesList);
            return View(dtoList);
        }
        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = _reservationService.GetListWithReservationByWaitAprroval(values.Id);
            var dtoList = _mapper.Map<List<ListReservationDto>>(valuesList);
            return View(dtoList);
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            List<SelectListItem> values = (from x in _destinationService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.City,
                                               Value = x.DestinationID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewReservation(Reservation p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p.AppUserId = values.Id;
            p.Status = "Onay Bekliyor";
            p.DestinationID = p.DestinationID;
            _reservationService.TAdd(p);
            //return RedirectToAction("MyApprovalReservation");
            return RedirectToAction("Index", "Dashboard");
        }
    }
}

