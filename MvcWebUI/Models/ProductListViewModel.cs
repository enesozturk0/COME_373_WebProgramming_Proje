using Entities.Concretes;

namespace MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int? CurrentCategory { get; set; }
	}
}
