using JewelrySalesStoreData.Base;
using JewelrySalesStoreData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelrySalesStoreData.Repository
{
    public class OrderDetailRepository : GenericRepository<OrderDetail>
    {
        public OrderDetailRepository() { 
        }

        public OrderDetailRepository(Net17022214JewelrySalesStoreContext context) : base(context) => _context = context;
    }
}
