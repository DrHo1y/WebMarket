using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Models;

namespace WebMarket.Data.Interfaces
{
    public interface IGPU
    {
        public IEnumerable<GraphicalCard> AllGPU { get; }
        public GraphicalCard GPU(int Id);
    }
}
