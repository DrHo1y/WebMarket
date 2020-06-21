using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Models;

namespace WebMarket.Data.Mocks
{
    public class MockMotherboard : IMotherboard
    {
        private readonly IProductRange _Product = new MockProductRange();
        public IEnumerable<Motherboard> AllMotherboards
        {
            get
            {
                return new List<Motherboard>
                {
                    new Motherboard
                    {
                        Id = 1, ProductRangeId = 5,
                        Name = "Материнская плата Gigabyte B450M DS3H (rev. 1.0)", Description = "mATX, сокет AMD AM4, чипсет AMD B450, память 4хDDR4," + 
                        "слоты: 2xPCIe x16, 1xPCIe x1, 1xM.2", MarketEntryDate = "2018", Cost = 190, ProcessorSupport = "AMD", Socket = "AM4", Chipset = "AMD B450",
                        FormFactor = "mATX", Backlight = false, MemoryType = "DDR4", MemorySlots = 4, MaxMemoryCapacity = "64GB", MemoryMode = "двухканальный", 
                        MaxMemoryFrequency = "3600 МГц", ProductRange = _Product.GetProduct(5), Image = "/img/MB/GigabyteB450MDS3H.jpeg"
                    },
                    new Motherboard
                    {
                        Id = 2, ProductRangeId = 6,
                        Name = "Материнская плата MSI MPG Z490 Gaming Plus", Description = "ATX, сокет Intel LGA1200, чипсет Intel Z490, память 4xDDR4," + 
                        "слоты: 2xPCIe x16, 3xPCIe x1, 2xM.2", MarketEntryDate = "2020", Cost = 500, ProcessorSupport = "Intel", Socket = "LGA1200", 
                        Chipset = "Intel Z490", FormFactor = "ATX", Backlight = true, MemoryType = "DDR4", MemorySlots = 4, MaxMemoryCapacity = "128GB", 
                        MemoryMode = "двухканальный", MaxMemoryFrequency = "48000 МГц", ProductRange = _Product.GetProduct(6), Image = "/img/MB/MSIZ490GP.jpeg"
                    }
                };
            }
        }
        public Motherboard Motherboard(int Id)
        {
            foreach (Motherboard itm in AllMotherboards)
            {
                if (itm.Id == Id)
                {
                    return itm;
                }
            }
            return AllMotherboards.First();
        }
    }
}