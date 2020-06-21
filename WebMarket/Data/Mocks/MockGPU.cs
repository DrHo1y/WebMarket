using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Models;

namespace WebMarket.Data.Mocks
{
    public class MockGPU : IGPU
    {
        private readonly IProductRange _Product = new MockProductRange();
        public IEnumerable<GraphicalCard> AllGPU
        {
            get
            {
                return new List<GraphicalCard>
                {
                    new GraphicalCard 
                    {
                        Id = 1, ProductRangeId = 3,
                        Name = "Видеокарта Gigabyte GeForce GTX 1660 Super", Description = "NVIDIA GeForce GTX 1660 Super, базовая частота 1530 МГц, " +
                        "Turbo-частота 1860 МГц, 1408sp, частота памяти 3500 МГц, 192 бит, доп. питание: 8 pin, 2 слота, HDMI, DisplayPort", 
                        Cost = 750, MarketEntryDate = "2019", Interface = "PCI Express x16 3.0", Manufacturer = "NVIDIA",
                        GPU = "GeForce GTX 1660 Super", OverclockedVersion = true, Frequency = "1 530 МГц", TurboFrequency = "1 860 МГц",
                        NumberOfStreamProcessors = 1408, VideoMemory = "6 ГБ", TypeMemory = "GDDR6", MemoryFrequency = "3500 МГц", MemoryBusWidth = 192,
                        ProductRange = _Product.GetProduct(3), Image = "/img/GPU/GigabyteGTX1660S.jpeg"
                    }, 
                    new GraphicalCard
                    {
                        Id = 2, ProductRangeId = 4,
                        Name = "Видеокарта Gigabyte Radeon RX 580", Description = "AMD Radeon RX 580, базовая частота 1340 МГц, 2304sp, частота памяти," + 
                        "2000 МГц, 256 бит, доп. питание: 8 pin, 2 слота, DVI, HDMI, DisplayPort", Cost = 570, MarketEntryDate = "2017", 
                        Interface = "PCI Express x16 3.0", Manufacturer = "AMD", GPU = "Radeon RX 580", OverclockedVersion = false, Frequency = "1340 МГц",
                        TurboFrequency = null,
                        NumberOfStreamProcessors = 2304, VideoMemory = "8 ГБ", TypeMemory = "GDDR5", MemoryFrequency = "2000 МГц", MemoryBusWidth = 256,
                        ProductRange = _Product.GetProduct(4), Image = "/img/GPU/GigabyteRX580.jpeg"
                    } 
                };
            }
        }
        public GraphicalCard GPU(int Id)
        {
            foreach(GraphicalCard itm in AllGPU)
            {
                if (itm.Id == Id)
                {
                    return itm;
                }
            }
            return AllGPU.First();
        }
    }
}
