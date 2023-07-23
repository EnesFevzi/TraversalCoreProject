using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DtoLayer.Dtos.TestimonialDto;

namespace TraversalProject.WebUI.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public _Testimonial(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var testimonials = _testimonialService.TGetList();
            var testimonialDtos = _mapper.Map<List<ListTestimonialDto>>(testimonials);
            return View(testimonialDtos);
        }
    }
}
