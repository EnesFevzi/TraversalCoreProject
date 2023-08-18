using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.CoreLayer.Entities;
using TraversalProject.DataAccessLayer.Abstract;

namespace TraversalProject.DataAccessLayer.UnıtOfWorks
{
    public interface IUnıtOfWork : IAsyncDisposable
    {
        IGenericDal<T> GetDal<T>() where T : class,IEntityBase,new();
        void Save();
    }
}
