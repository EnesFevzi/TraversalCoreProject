using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.DtoLayer.Dtos.CommentDto;
using TraversalProject.DtoLayer.Dtos.SubAutoDto;

namespace TraversalProject.WebUI.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        private readonly ICommentService _commentService;
        private readonly TContext _context;
        private readonly IMapper _mapper;

        public _CommentList(ICommentService commentService, TContext context, IMapper mapper)
        {
            _commentService = commentService;
            _context = context;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            ViewBag.commentCount = _context.Comments.Where(x => x.DestinationID == id).Count();
            var commentList = await _commentService.TGetListCommentWithDestinationAndUserAsync(id);
            var commentListDto = _mapper.Map<List<ListCommentDto>>(commentList);
            return View(commentListDto);
        }
    }
}
