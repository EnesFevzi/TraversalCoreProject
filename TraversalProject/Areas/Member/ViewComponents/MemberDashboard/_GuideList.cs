using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DtoLayer.Dtos.GuideDto;

namespace TraversalProject.WebUI.Areas.Member.ViewComponents.MemberDashboard
{
    public class _GuideList:ViewComponent
    {
        private readonly IGuideService _guideService;
        private readonly IMapper _mapper;

        public _GuideList(IGuideService guideService, IMapper mapper)
        {
            _guideService = guideService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values = _guideService.TGetList();
            var guidListDto= _mapper.Map<List<ListGuideDto>>(values);
            return View(guidListDto);
        }
    }
}
