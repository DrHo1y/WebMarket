using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Models;

namespace WebMarket.Data.Interfaces
{
    public interface IMotherboard
    {
        public IEnumerable<Motherboard> AllMotherboards { get; }

        public Motherboard Motherboard(int Id);
    }
}
