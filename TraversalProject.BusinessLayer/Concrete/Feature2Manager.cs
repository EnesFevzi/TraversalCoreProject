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
    public class Feature2Manager : IFeature2Service
    {
        private readonly IFeature2Dal _featureDal;

        public Feature2Manager(IFeature2Dal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature2 t)
        {
            _featureDal.Add(t);
        }

        public void TDelete(Feature2 t)
        {
            _featureDal.Delete(t);
        }

        public List<Feature2> TGetByFilter(Expression<Func<Feature2, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Feature2 TGetByFilter2(Expression<Func<Feature2, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Feature2 TGetByID(int id)
        {
            return _featureDal.GetByID(id);
        }

        public List<Feature2> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature2 t)
        {
            _featureDal.Update(t);
        }
    }
}
