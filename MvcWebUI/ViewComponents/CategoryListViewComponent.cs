using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Models;

namespace MvcWebUI.ViewComponents
{
    public class CategoryListViewComponent :ViewComponent

    {
       private ICategoryService _categoryService;

       public CategoryListViewComponent(ICategoryService categoryService)
       {
           _categoryService = categoryService;
       }


       public IViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["category"])
            };
            return View(model);
        }
    }
}
