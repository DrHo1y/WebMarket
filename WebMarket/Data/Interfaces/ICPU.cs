using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Models;

namespace WebMarket.Data.Interfaces
{
    public interface ICPU
    {
        public IEnumerable<Processor> GetCPUs { get; }
        public Processor GetCPU(int id);
    }
}
