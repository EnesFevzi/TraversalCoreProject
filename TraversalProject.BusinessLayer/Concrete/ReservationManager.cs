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
    public class ReservationManager : IReservationService
    {
        private readonly IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void TAdd(Reservation t)
        {
            _reservationDal.Add(t);
        }

        public void TDelete(Reservation t)
        {
           _reservationDal.Delete(t);
        }

        public List<Reservation> TGetByFilter(Expression<Func<Reservation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetByFilter2(Expression<Func<Reservation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetByID(int id)
        {
           return _reservationDal.GetByID(id);  
        }

        public List<Reservation> TGetList()
        {
            return _reservationDal.GetList();
        }

        public void TUpdate(Reservation t)
        {
            _reservationDal.Update(t);
        }
    }
}
