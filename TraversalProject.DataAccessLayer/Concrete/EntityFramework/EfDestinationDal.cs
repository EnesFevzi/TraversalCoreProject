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
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {

        public EfDestinationDal(TContext context) : base(context)
        {

        }
        public Destination GetDestinationWithGuide(int id)
        {
            return _context.Destinations.Where(x => x.DestinationID == id).Include(x => x.Guide).FirstOrDefault();
            // "Context" burada GenericRepository sınıfından gelen DbContext'i temsil eder.
        }

        public List<Destination> GetLast4Destinations()
        {
            var values = _context.Destinations.Take(4).OrderByDescending(x => x.DestinationID).ToList();
            // "Context" burada GenericRepository sınıfından gelen DbContext'i temsil eder.
            return values;
        }


    }

}


