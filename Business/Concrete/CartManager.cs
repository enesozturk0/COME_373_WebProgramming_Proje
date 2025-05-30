using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete.DomainModels;
using Entities.Concretes;

namespace Business.Concrete
{
    public class CartManager:ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(c=>c.Product.ProductId==product.ProductId);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            else
            {
                cart.CartLines.Add(new CartLine{Product = product, Quantity = 1});
            }
        }

        public void RemoveFromCart(Cart cart, int productId)
        {//FirstOrDefault Koşulu sağlayan ilk elemanı döner. yoksa null döner
            CartLine cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId);
            if (cartLine.Quantity ==1)
            {
                cart.CartLines.Remove(cartLine);
            }
            else
            {
                cartLine.Quantity--;
            }

        }
        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }
    }
}
