using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.DataAccessLayer.Abstract
{
    public interface IFeatureDal:IGenericDal<Feature>
    {
    }
}
