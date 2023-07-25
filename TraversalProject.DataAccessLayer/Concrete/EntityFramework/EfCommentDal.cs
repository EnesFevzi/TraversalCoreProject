using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.DataAccessLayer.Repository;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public EfCommentDal(TContext context) : base(context)
        {
        }


        public List<Comment> GetListCommentWithDestinationAndUser(int id)
        {

                return _context.Comments.Where(x => x.DestinationID == id).Include(x => x.AppUser).ToList();
            
        }

        public async Task<List<Comment>> GetListCommentWithDestinationAsync()
        {
            return await _context.Comments.Include(x => x.Destination).ToListAsync();
        }

        public async Task<List<Comment>> GetListCommentWithDestinationAndUserAsync(int id)
        {
            return await _context.Comments.Where(x => x.DestinationID == id).Include(x => x.AppUser).ToListAsync();
        }


    }
}
