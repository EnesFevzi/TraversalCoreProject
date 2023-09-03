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
    public class EfGuideDal : GenericRepository<Guide>, IGuideDal
    {
        public EfGuideDal(TContext context) : base(context)
        {
        }

        public void ChangeToFalseByGuide(int id)
        {
            var values = _context.Guides.FirstOrDefault(x => x.GuideID == id);
            values.Status = false;
            _context.SaveChanges();
        }

        public void ChangeToTrueByGuide(int id)
        {
            var values = _context.Guides.FirstOrDefault(x => x.GuideID == id);
            values.Status = true;
            _context.SaveChanges();
        }
    }
}
