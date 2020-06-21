using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Models;

namespace WebMarket.Data.Mocks
{
    public class MockBasket : IBasket
    {

        private readonly IProductRange _Product = new MockProductRange();

        public Basket Basket => throw new NotImplementedException();
    }
}