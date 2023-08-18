using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.DataAccessLayer.Concrete;
using TraversalProject.DataAccessLayer.Repository;

namespace TraversalProject.DataAccessLayer.UnıtOfWorks
{
    public class UnıtOfWork : IUnıtOfWork
    {
        private readonly TContext _context;

        public UnıtOfWork(TContext context)
        {
            _context = context;
        }

        public async ValueTask DisposeAsync()
        {
           await _context.DisposeAsync();
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }

        IGenericDal<T> IUnıtOfWork.GetDal<T>()
        {
            return new GenericRepository<T>(_context);
        }
    }
}
