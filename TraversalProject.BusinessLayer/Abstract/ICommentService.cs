﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TraversalProject.EntityLayer.Concrete;

namespace TraversalProject.BusinessLayer.Abstract
{
    public interface ICommentService:IGenericService<Comment>
    {
        Task<List<Comment>> TGetListCommentWithDestinationAsync();
        Task<List<Comment>> TGetListCommentWithDestinationAndUserAsync(int id);


    }
}
