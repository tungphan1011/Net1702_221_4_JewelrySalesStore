using JewelrySalesStoreBusiness;
using JewelrySalesStoreData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JewelrySalesStoreRazorWebApp.Pages
{
    public class ProductModel : PageModel
    {
        private readonly ProductBusiness _productBusiness = new ProductBusiness();
        public void OnGet()
        {
        }

        public Product Product { get; set; }

        public List<Product> GetProducts()
        {
            var productResult = _productBusiness.GetAll();

            if (productResult.Status > 0 && productResult.Result.Data != null)
            {
                var products = (List<Product>)productResult.Result.Data;
                return products;
            }
            return new List<Product>();
        }
    }
}
