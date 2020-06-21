using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Models;

namespace WebMarket.ViewModels.MB
{
    public class MBListViewModel
    {
        public IEnumerable<Motherboard> GetAllMB { set; get; }
    }
}
