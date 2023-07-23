using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.BusinessLayer.Concrete;
using TraversalProject.DataAccessLayer.Concrete.EntityFramework;
using TraversalProject.DtoLayer.Dtos.SubAutoDto;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.WebUI.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        private readonly ISubAboutService _subAboutService;
        private readonly IMapper _mapper;
        public _SubAbout(ISubAboutService subAboutService, IMapper mapper)
        {
            _subAboutService = subAboutService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var subAbout = _subAboutService.TGetList();
            var subAboutDtos = _mapper.Map<List<ListSubAboutDto>>(subAbout);
            return View(subAboutDtos);
        }
    }
}
