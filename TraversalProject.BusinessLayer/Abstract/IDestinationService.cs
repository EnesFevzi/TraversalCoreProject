using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.Abstract
{
    public interface IDestinationService:IGenericService<Destination>
    {
        public Destination TGetDestinationWithGuide(int id);
        public Destination GetDestinationByID2(int id);
    }
}
