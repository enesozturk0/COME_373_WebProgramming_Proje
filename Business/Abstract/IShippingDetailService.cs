﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IShippingDetailService
    {
        public void AddShippingDetail(ShippingDetail shippingDetail);
    }
}
