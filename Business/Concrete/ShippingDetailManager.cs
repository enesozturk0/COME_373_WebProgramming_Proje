using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ShippingDetailManager:IShippingDetailService
    {
        private IShippingDetailDal _shippingDetailDal;

        public ShippingDetailManager(IShippingDetailDal shippingDetailDal)
        {
            _shippingDetailDal = shippingDetailDal;
        }

        public void AddShippingDetail(ShippingDetail shippingDetail)
        {
            _shippingDetailDal.Add(shippingDetail);
            
        }
    }
}
