using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Models;

namespace WebMarket.ViewModels.CPU
{
    public class CPUListViewModel
    {
        public IEnumerable<Processor> GetAllCPU { get; set; }
    }
}