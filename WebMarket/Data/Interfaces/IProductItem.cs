using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Models;

namespace WebMarket.Data.Interfaces
{
    public interface IProductItem
    {
        public IEnumerable<ProductItem> Item { get; }
    }
}
