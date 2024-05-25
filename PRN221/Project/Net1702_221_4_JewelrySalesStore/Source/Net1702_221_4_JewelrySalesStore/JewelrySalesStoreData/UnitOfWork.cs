using JewelrySalesStoreData.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelrySalesStoreData
{
    public class UnitOfWork
    {
        private CategoryRepository _category;
        private ProductRepository _product;
        private CompanyRepository _company;

        public UnitOfWork() { 
        }

        public CategoryRepository CategoryRepository
        {
            get
            {
                return _category ??= new Repository.CategoryRepository();
            }
        }

        public ProductRepository ProductRepository
        {
            get
            {
                return _product ??= new Repository.ProductRepository();
            }
        }

        public CompanyRepository CompanyRepository
        {
            get
            {
                return _company ??= new Repository.CompanyRepository();
            }
        }
    }
}
