using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Models;

namespace WebMarket.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Basket> Basket { set; get; }
        public DbSet<GraphicalCard> GPU { set; get; }
        public DbSet<Motherboard> MB { set; get; }
        public DbSet<Processor> CPU { set; get; }
        public DbSet<ProductRange> ProductRange { set; get; }
        public DbSet<ProductItem> ProductItem { set; get; }
        public DbSet<Order> Order { set; get; }
        public DbSet<OrderDetail> OrderDetail { set; get; }
    }
}
