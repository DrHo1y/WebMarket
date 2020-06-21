using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebMarket.Data.Mocks;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Models;
using System.Collections.Generic;
using System.Linq;
using WebMarket.Data.Repository;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ICPU CPU = new MockCPU();
            Processor[] example = CPU.GetCPUs.ToArray();
            foreach(Processor x in example)
            {
                //Name = "Процессор AMD Ryzen 5 2600", Description = "Pinnacle Ridge, AM4, 6 ядер, частота 3.9/3.4 ГГц, кеш 3 МБ + 16 МБ," +
                        //"техпроцесс 12 нм, TP 65W", MarketEntryDate = DateTime.Parse("2018"), Cost = 320, Socket = "AM4", NumberCores = 6, MaximumNumberThreads = 12,
                        //Baseclock = "3.4 ГГц", MaximumFrequency = "3.9 ГГЦ", L2cache = "3 МБ", L3cache = "16 МБ", MemorySupport = "DDR4", NumberOfChannels = "2", 
                        //MaxMemoryFrequency = "2993 МГц", ProductRange = _Product.GetProduct(1)
                System.Console.WriteLine($"{x.Name}, {x.Description}, {x.MarketEntryDate}, {x.Cost}, {x.Socket}, {x.NumberCores}, {x.MaximumNumberThreads}, {x.Baseclock}," +
                    $"{x.MaximumFrequency}, {x.L2cache}, {x.L3cache}, {x.MemorySupport}, {x.NumberOfChannels}, {x.MaxMemoryFrequency}, " +
                    $"{x.ProductRange}");
                System.Console.WriteLine("----");
            }
        }
    }
}
