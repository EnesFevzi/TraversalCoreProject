using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TAdd(Comment t)
        {
           _commentDal.Add(t);
        }

        public void TDelete(Comment t)
        {
           _commentDal.Delete(t);
        }

        public List<Comment> TGetByFilter(Expression<Func<Comment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Comment TGetByFilter2(Expression<Func<Comment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Comment TGetByID(int id)
        {
            return _commentDal.GetByID(id); 
        }

        public List<Comment> TGetList()
        {
           return _commentDal.GetList();
        }

        public async Task<List<Comment>> TGetListCommentWithDestinationAsync()
        {
            return await _commentDal.GetListCommentWithDestinationAsync();
        }

        public async Task<List<Comment>> TGetListCommentWithDestinationAndUserAsync(int id)
        {
            return await _commentDal.GetListCommentWithDestinationAndUserAsync(id);
        }

        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }


    }
}
