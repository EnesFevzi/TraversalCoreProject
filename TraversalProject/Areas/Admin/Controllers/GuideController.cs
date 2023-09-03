using AutoMapper;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DtoLayer.Dtos.DestinationDto;
using TraversalProject.DtoLayer.Dtos.GuideDto;
using TraversalProject.EntityLayer.Concrete;
using TraversalProject.WebUI.ValidationRules;

namespace TraversalProject.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;
        private readonly IMapper _mapper;

        public GuideController(IGuideService guideService, IMapper mapper)
        {
            _guideService = guideService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _guideService.TGetList();
            var listGuideDto = _mapper.Map<List<ListGuideDto>>(values);
            return View(listGuideDto);
        }
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGuide(AddGuideDto addGuideDto)
        {
            var guide = _mapper.Map<Guide>(addGuideDto);

            GuideValidator validationRules = new GuideValidator();
            ValidationResult result = validationRules.Validate(guide);

            if (result.IsValid)
            {
                _guideService.TAdd(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }


        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.TGetByID(id);
            var idd = values.GuideID;
            var guideDto = _mapper.Map<UpdateGuideDto>(values);
            return View(guideDto);

        }
        [HttpPost]
        public IActionResult EditGuide(UpdateGuideDto guideDto)
        {
            if (ModelState.IsValid)
            {
                var values = _mapper.Map<Guide>(guideDto);
                _guideService.TUpdate(values);
                return RedirectToAction("Index");
            }
            return View(guideDto);


        }

        public IActionResult ChangeToTrue(int id)
        {
            _guideService.TChangeToTrueByGuide(id);
            //return RedirectToAction("Index", "Guide", new { area = "Admin" });
            return RedirectToAction("Index");
        }


        public IActionResult ChangeToFalse(int id)
        {
            _guideService.TChangeToFalseByGuide(id);
            //return RedirectToAction("Index", "Guide", new { area = "Admin" });
            return RedirectToAction("Index");
        }
    }

}