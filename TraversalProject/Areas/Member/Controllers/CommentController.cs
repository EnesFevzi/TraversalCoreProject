using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DtoLayer.Dtos.DestinationDto;

namespace TraversalProject.WebUI.Areas.Member.Controllers
{
    [Area("Member")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        public async Task< IActionResult> Index()
        {
            var values = await  _commentService.TGetListCommentWithDestinationAsync();
            var destinationDtos = _mapper.Map<List<ListDestinationDto>>(values);
            return View(destinationDtos);
        }
    }
}
