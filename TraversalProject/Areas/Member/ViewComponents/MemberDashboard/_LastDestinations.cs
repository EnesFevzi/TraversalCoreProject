using AutoMapper;
using MailKit.Net.Imap;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.DtoLayer.Dtos.DestinationDto;

namespace TraversalProject.WebUI.Areas.Member.ViewComponents.MemberDashboard
{
    public class _LastDestinations : ViewComponent
    {
        private readonly IDestinationService _destinationService;
        private readonly IMapper _mapper;

        public _LastDestinations(IDestinationService destinationService, IMapper mapper)
        {
            _destinationService = destinationService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.TGetList().Take(4).ToList();
            var listDestinationDto = _mapper.Map<List<ListDestinationDto>>(values);
            return View(listDestinationDto);
        }
    }
}
