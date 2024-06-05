using JewelrySalesStoreData.Models;
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
        private Net17022214JewelrySalesStoreContext _unitOfWorkContext;

        private CompanyRepository _company;
        private OrderDetailRepository _detail;
        private PromotionRepository _promotion;

        public UnitOfWork()
        {
            _unitOfWorkContext ??= new Net17022214JewelrySalesStoreContext();
        }

        public CompanyRepository CompanyRepository
        {
            get
            {
                return _company ??= new Repository.CompanyRepository(_unitOfWorkContext);
            }
        }

        public OrderDetailRepository OrderDetailRepository
        {
            get
            {
                return _detail ??= new Repository.OrderDetailRepository(_unitOfWorkContext);
            }
        }

        public PromotionRepository PromotionRepository
        {
            get
            {
                return _promotion ??= new Repository.PromotionRepository();
            }
        }
    }
}
