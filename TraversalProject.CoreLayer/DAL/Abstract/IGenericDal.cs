using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TraversalProject.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetByID(int id);
        List<T> GetByFilter(Expression<Func<T, bool>> filter);
        T GetByFilter2(Expression<Func<T, bool>> filter);
    }
}
