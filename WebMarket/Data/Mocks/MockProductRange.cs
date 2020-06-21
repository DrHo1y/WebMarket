using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Models;

namespace WebMarket.Data.Mocks
{
    public class MockProductRange : IProductRange
    {
        public IEnumerable<ProductRange> GetProducts
        {
            get
            {
                return new List<ProductRange>()
                {
                    new ProductRange
                    {
                        Id = 1,
                        VendorCode = "355GW-AMD5RYZEN2600OEM"
                    },
                    new ProductRange
                    {
                        Id = 2,
                        VendorCode = "396GW-AMD5RYZEN3600OEM"
                    },
                    new ProductRange
                    {
                        Id = 3,
                        VendorCode = "GV-N166SGAMING"
                    },
                    new ProductRange
                    {
                        Id = 4,
                        VendorCode = "GV-RX580GAMING"
                    },
                    new ProductRange
                    {
                        Id = 5,
                        VendorCode = "MK16A1"
                    },
                    new ProductRange
                    {
                        Id = 6,
                        VendorCode = "RD185A7"
                    }
                };
            }
        }

        public ProductRange GetProduct(int id)
        {
            foreach(ProductRange Product in GetProducts)
            {
                if (Product.Id == id)
                {
                    return Product;
                }
            }
            return GetProducts.First();
        }
    }
}