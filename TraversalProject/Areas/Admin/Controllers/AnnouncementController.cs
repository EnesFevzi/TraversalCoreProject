using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DtoLayer.Dtos.AnnouncementDto;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _announcementService.TGetList();
            var AnnouncementDto = _mapper.Map<List<ListAnnouncementDto>>(values);
            return View(AnnouncementDto);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AddAnnouncementDto model)
        {
            if (ModelState.IsValid)
            {
                var newAnnouncement = new Announcement
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date = DateTime.Now
                };

                _announcementService.TAdd(newAnnouncement);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var values = _announcementService.TGetByID(id);
            _announcementService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
            var values = _mapper.Map<UpdateAnnouncementDto>(_announcementService.TGetByID(id));
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAnnouncement(UpdateAnnouncementDto model)
        {
            if (ModelState.IsValid)
            {
                var updatedAnnouncement = new Announcement
                {
                    AnnouncementID = model.AnnouncementID,
                    Title = model.Title,
                    Content = model.Content,
                    Date = DateTime.Now
                };

                _announcementService.TUpdate(updatedAnnouncement);
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
