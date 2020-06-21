using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Models;

namespace WebMarket.Data.Mocks
{
    public class MockProductItem : IProductItem
    {
        private readonly ICPU AllCPU = new MockCPU();
        private readonly IMotherboard AllMB = new MockMotherboard();
        public IEnumerable<ProductItem> Item
        {
            get
            {
                return new List<ProductItem>
                {
                    new ProductItem
                    {
                        Id = 1,
                        Image = AllCPU.GetCPU(2).Image,
                        Name = AllCPU.GetCPU(2).Name,
                        Cost = AllCPU.GetCPU(2).Cost,
                        IdProduct = AllCPU.GetCPU(2).ProductRangeId
                    },
                    new ProductItem
                    {
                        Id = 2,
                        Image = AllMB.Motherboard(1).Image,
                        Name = AllMB.Motherboard(1).Name,
                        Cost = AllMB.Motherboard(1).Cost,
                        IdProduct = AllMB.Motherboard(1).ProductRangeId
                    }
                };
            }
        }
    }
}
