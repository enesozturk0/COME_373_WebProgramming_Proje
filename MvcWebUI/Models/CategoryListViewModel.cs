﻿using Entities.Concretes;

namespace MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get;  set; }
    }
}
