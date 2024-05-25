using JewelrySalesStoreBusiness;
using JewelrySalesStoreData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JewelrySalesStoreRazorWebApp.Pages
{
    public class CompanyModel : PageModel
    {
        private readonly CompanyBusiness _companyBusiness = new CompanyBusiness();
        public void OnGet()
        {
        }

        public Company Company { get; set; }

        public List<Company> GetCompanies()
        {
            var companyResult = _companyBusiness.GetAll();

            if (companyResult.Status > 0 && companyResult.Result.Data != null)
            {
                var companies = (List<Company>)companyResult.Result.Data;
                return companies;
            }
            return new List<Company>();
        }
    }
}
