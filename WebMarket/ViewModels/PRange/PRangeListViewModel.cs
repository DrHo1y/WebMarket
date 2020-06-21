using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Models;

namespace WebMarket.ViewModels.PRange
{
    public class PRangeListViewModel
    {
        public IEnumerable<ProductRange> GetAllPRange { set; get; }
    }
}
