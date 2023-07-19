using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.BusinessLayer.Abstract;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal commentDal)
        {
            _contactDal = commentDal;
        }

        public void TAdd(Contact t)
        {
            _contactDal.Add(t);
        }

        public void TDelete(Contact t)
        {
           _contactDal.Delete(t);
        }

        public Contact TGetByID(int id)
        {
           return _contactDal.GetByID(id);  
        }

        public List<Contact> TGetList()
        {
           return _contactDal.GetList();
        }

        public void TUpdate(Contact t)
        {
           _contactDal.Update(t);
        }
    }
}
