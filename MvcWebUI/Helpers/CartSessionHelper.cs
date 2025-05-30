using Entities.Concrete.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MvcWebUI.Extensions;

namespace MvcWebUI.Helpers
{
    public class CartSessionHelper :ICartSessionHelper
    {
        private IHttpContextAccessor _httpContextAccessor;

        public CartSessionHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void Clear()
        {
            _httpContextAccessor.HttpContext.Session.Clear();
        }

        public Cart getCart(string key)
        {
            Cart cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>(key);
            if (cartToCheck == null)
            {
                setCart(key, new Cart());
                cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>(key);
            }

            return cartToCheck;
        }

        public Cart getCart()
        {
            throw new NotImplementedException();
        }

        public void setCart(string key,Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.SetObject(key, cart);
        }

        public void setCart(Cart cart)
        {
            throw new NotImplementedException();
        }
    }
}
