﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
       
    }
}
