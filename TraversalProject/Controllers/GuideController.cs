using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DtoLayer.Dtos.DestinationDto;
using TraversalProject.DtoLayer.Dtos.GuideDto;

namespace TraversalProject.WebUI.Controllers
{
    [AllowAnonymous]
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
            var guideDtos = _mapper.Map<List<ListGuideDto>>(values);
            return View(guideDtos);
        }
    }
}
