﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
