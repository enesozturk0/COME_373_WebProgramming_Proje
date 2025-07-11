﻿using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService

    {

        List<Product> GetAll();
        List<Product> GetByCategory(int? categoryId);
        Product GetById(int productId);
    }
}
