using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Abstract;
using Entities.Concretes;

namespace Entities.Concrete.DomainModels
{
    public class CartLine:IDomainModel
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
