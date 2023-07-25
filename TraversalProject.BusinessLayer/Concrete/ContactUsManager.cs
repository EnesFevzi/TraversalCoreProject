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
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TAdd(ContactUs t)
        {
           _contactUsDal.Add(t);
        }

        public void TDelete(ContactUs t)
        {
           _contactUsDal.Delete(t);
        }

        public List<ContactUs> TGetByFilter(Expression<Func<ContactUs, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public ContactUs TGetByFilter2(Expression<Func<ContactUs, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public ContactUs TGetByID(int id)
        {
            return _contactUsDal.GetByID(id);
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public void TUpdate(ContactUs t)
        {
           _contactUsDal.Update(t);
        }
    }
}
