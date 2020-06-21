using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Models;

namespace WebMarket.Data.Repository
{
    public class ProductRangeRepository : IProductRange
    {
        private readonly AppDBContent appDBContent;
        public ProductRangeRepository(AppDBContent appDBContent) => this.appDBContent = appDBContent;
        public IEnumerable<ProductRange> GetProducts => appDBContent.ProductRange.Include(c => c.Id);

        public ProductRange GetProduct(int Id) => appDBContent.ProductRange.FirstOrDefault(c => c.Id == Id);
    }
}
