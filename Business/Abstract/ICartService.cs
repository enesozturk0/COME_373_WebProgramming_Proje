using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete.DomainModels;
using Entities.Concretes;

namespace Business.Abstract
{
    public interface ICartService
    {
        public void AddToCart(Cart cart, Product product) { }

        public void RemoveFromCart(Cart cart, int productId) { }

        List<CartLine> List(Cart cart);
    }
}
