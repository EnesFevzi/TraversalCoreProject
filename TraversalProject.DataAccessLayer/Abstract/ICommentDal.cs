﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.DataAccessLayer.Abstract
{
    public interface ICommentDal:IGenericDal<Comment>
    {
        Task<List<Comment>> GetListCommentWithDestinationAsync();
        Task<List<Comment>> GetListCommentWithDestinationAndUserAsync(int id);

    }
}
