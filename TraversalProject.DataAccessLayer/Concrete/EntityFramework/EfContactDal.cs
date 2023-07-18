﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.DataAccessLayer.Abstract;
using TraversalProject.DataAccessLayer.Repository;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public EfContactDal(TContext context) : base(context)
        {
        }
    }
}
