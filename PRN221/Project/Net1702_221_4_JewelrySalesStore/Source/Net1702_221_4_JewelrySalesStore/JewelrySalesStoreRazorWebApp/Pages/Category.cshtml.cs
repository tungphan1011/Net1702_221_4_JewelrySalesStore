using JewelrySalesStoreBusiness;
using JewelrySalesStoreData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JewelrySalesStoreRazorWebApp.Pages
{
    public class CategoryModel : PageModel
    {
        private readonly CategoryBusiness _categoryBusiness = new CategoryBusiness();
        public void OnGet()
        {
        }

        public Category Category { get; set; }

        public List<Category> GetCategories()
        {
            var categoryResult = _categoryBusiness.GetAll();

            if (categoryResult.Status > 0 && categoryResult.Result.Data != null)
            {
                var categories = (List<Category>)categoryResult.Result.Data;
                return categories;
            }
            return new List< Category>();
        }
    }
}
