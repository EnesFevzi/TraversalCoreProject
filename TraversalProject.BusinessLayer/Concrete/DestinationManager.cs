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
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public List<Destination> GetDestinationByID(int id)
        {
            return _destinationDal.GetByFilter(x => x.DestinationID == id);
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Add(t);
        }

        public void TDelete(Destination t)
        {
           _destinationDal.Delete(t);
        }

        public List<Destination> TGetByFilter(Expression<Func<Destination, bool>> filter)
        {
           return _destinationDal.GetByFilter(filter);
        }

        public Destination TGetByFilter2(Expression<Func<Destination, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Destination TGetByID(int id)
        {
            return _destinationDal.GetByID(id);
        }

        public Destination TGetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }

        public List<Destination> TGetList()
        {
           return _destinationDal.GetList();
        }

        public void TUpdate(Destination t)
        {
           _destinationDal.Update(t);
        }

       public Destination GetDestinationByID2(int id)
        {
            return _destinationDal.GetByFilter2(x => x.DestinationID == id);
        }
    }
}
