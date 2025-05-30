using Business.Abstract;
using Entities.Concretes;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int? category, int page = 1, int pageSize = 18)
        {
           
            var products = category > 0
                ? _productService.GetByCategory(category.Value) 
                : _productService.GetAll();                       
            
            var pagedProducts = products
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            
            var model = new ProductListViewModel
            {
                Products = pagedProducts,
                CurrentCategory = category,
                TotalPages = (int)Math.Ceiling((double)products.Count() / pageSize),
                CurrentPage = page
            };

            return View(model);
        }
    }
}


