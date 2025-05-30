using Business.Abstract;
using Entities.Concrete;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Helpers;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private ICartSessionHelper _cartSessionHelper;
        private IProductService _productService;
        IShippingDetailService _shippingDetailService;


        public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper,
            IProductService productService, IShippingDetailService shippingDetailService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
            _shippingDetailService = shippingDetailService;
        }

        public IActionResult AddToCart(int productId)
        {
            // ürünü çek
            Product product = _productService.GetById(productId);

            var cart = _cartSessionHelper.getCart("cart");
            _cartService.AddToCart(cart, product);
            _cartSessionHelper.setCart("cart", cart);
            TempData.Add("message", product.ProductName + " Added to Cart.");
            return RedirectToAction("Index", "Product");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            Product product = _productService.GetById(productId);

            var cart = _cartSessionHelper.getCart("cart");
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionHelper.setCart("cart", cart);
            TempData.Add("message", product.ProductName + " Removed From Cart.");
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Index()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionHelper.getCart("cart")

            };

            return View(model);
        }

        public IActionResult CompleteOrder()
        {

            var model = new ShippingDetailsViewModel
            {
                ShippingDetail = new ShippingDetail()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult CompleteOrder(ShippingDetail shippingDetail)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _shippingDetailService.AddShippingDetail(shippingDetail);
            TempData.Add("message", " Order Completed Succesfully!");
            _cartSessionHelper.Clear();
            return RedirectToAction("Index", "Cart");
        }
    }
}

