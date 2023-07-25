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
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
            _featureDal.Add(t);
        }

        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public List<Feature> TGetByFilter(Expression<Func<Feature, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Feature TGetByFilter2(Expression<Func<Feature, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Feature TGetByID(int id)
        {
            return _featureDal.GetByID(id); 
        }

        public List<Feature> TGetList()
        {
           return _featureDal.GetList();
        }

        public void TUpdate(Feature t)
        {
           _featureDal.Update(t);
        }
    }
}
