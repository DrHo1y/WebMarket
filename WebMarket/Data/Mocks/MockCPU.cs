using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Models;

namespace WebMarket.Data.Mocks
{
    public class MockCPU : ICPU
    {
        private readonly IProductRange _Product = new MockProductRange();
        public IEnumerable<Processor> GetCPUs
        {
            get
            {
                return new List<Processor>()
                {
                    new Processor
                    {
                        Id = 1, ProductRangeId = 1,
                        Name = "Процессор AMD Ryzen 5 2600", Description = "Pinnacle Ridge, AM4, 6 ядер, частота 3.9/3.4 ГГц, кеш 3 МБ + 16 МБ," +
                        "техпроцесс 12 нм, TP 65W", MarketEntryDate = "2018", Cost = 320, Socket = "AM4", NumberCores = 6, MaximumNumberThreads = 12,
                        Baseclock = "3.4 ГГц", MaximumFrequency = "3.9 ГГЦ", L2cache = "3 МБ", L3cache = "16 МБ", MemorySupport = "DDR4", NumberOfChannels = "2",
                        MaxMemoryFrequency = "2993 МГц", ProductRange = _Product.GetProduct(1), Image = "/img/CPU/amd.jpeg"
                    },
                    new Processor
                    {
                        Id = 2, ProductRangeId = 2,
                        Name = "Процессор AMD Ryzen 5 3600", Description = "Matisse, AM4, 6 ядер, частота 4.2/3.6 ГГцб кэш 3 МБ + 32 МБ, техпроцесс 7 нм, TDP 65W",
                        MarketEntryDate = "2019-01", Cost = 450, Socket = "AM4", NumberCores = 6, MaximumNumberThreads = 12, Baseclock = "3.6 ГГц",
                        MaximumFrequency = "4.2 ГГц", L2cache = "3 МБ", L3cache = "32 МБ", MemorySupport = "DDR4", NumberOfChannels = "2", MaxMemoryFrequency = "3200 МГц",
                        ProductRange = _Product.GetProduct(2), Image = "/img/CPU/amd.jpeg"
                    }
                };
            }
        }
        public Processor GetCPU(int id)
        {
            foreach (Processor Product in GetCPUs)
            {
                if (Product.Id == id)
                {
                    return Product;
                }
            }
            return GetCPUs.First();
        }
    }
}