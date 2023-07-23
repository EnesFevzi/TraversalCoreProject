using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.BusinessLayer.Concrete;
using TraversalProject.DataAccessLayer.Concrete.EntityFramework;
using TraversalProject.DtoLayer.Dtos.DestinationDto;

namespace TraversalProject.WebUI.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        private readonly IDestinationService _destinationService;
        private readonly IMapper _mapper;

        public _PopularDestinations(IDestinationService destinationService, IMapper mapper)
        {
            _destinationService = destinationService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var destinations = _destinationService.TGetList();
            var destinationDtos = _mapper.Map<List<ListDestinationDto>>(destinations);
            return View(destinationDtos);
        }
    }
}
