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
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public EfReservationDal(TContext context) : base(context)
        {
        }
        public List<Reservation> GetListWithReservationByAccepted(int id)
        {

                return _context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onaylandı" && x.AppUserId == id).ToList();

        }

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {

                return _context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id).ToList();

        }

        public List<Reservation> GetListWithReservationByWaitAprroval(int id)
        {

                return _context.Reservations.Include(x => x.Destination).Where(x => x.Status == "Onay Bekliyor" && x.AppUserId == id).ToList();

        }
    }
}
