﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Abstract;
using Entities.Concretes;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {

    }
}
