using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Models;

namespace WebMarket.Data.Interfaces
{
    public interface IAllOrders
    {
        public void CreateOrder(Order order);
    }
}
