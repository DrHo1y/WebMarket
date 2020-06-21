using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Models;

namespace WebMarket.ViewModels.GPU
{
    public class GPUListViewModel
    {
        public IEnumerable<GraphicalCard> GetAllGPU { get; set; }
    }
}
