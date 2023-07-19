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
    public class NewsLetterManager : INewsLetterService
    {
        private readonly INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void TAdd(Newsletter t)
        {
            _newsLetterDal.Add(t);
        }

        public void TDelete(Newsletter t)
        {
           _newsLetterDal.Delete(t);
        }

        public Newsletter TGetByID(int id)
        {
            return _newsLetterDal.GetByID(id);
        }

        public List<Newsletter> TGetList()
        {
            return _newsLetterDal.GetList();
        }

        public void TUpdate(Newsletter t)
        {
            _newsLetterDal.Update(t);
        }
    }
}
