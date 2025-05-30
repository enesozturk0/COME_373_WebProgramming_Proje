using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Abstract;

namespace Entities.Concrete.DomainModels
{
    public class Cart:IDomainModel
    {
        public Cart()
        {
            CartLines = new List<CartLine>();

        }
        public List<CartLine> CartLines { get; set; }

      
    }
}
