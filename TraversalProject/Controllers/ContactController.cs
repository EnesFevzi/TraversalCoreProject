using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DtoLayer.Dtos.MessageDto;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;

        public ContactController(IContactUsService contactUsService, IMapper mapper)
        {
            _contactUsService = contactUsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            if (ModelState.IsValid)
            {
                model.MessageDate = DateTime.Now;
                var destination = _mapper.Map<ContactUs>(model);
                _contactUsService.TAdd(destination);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
