using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Models;

namespace WebMarket.Data.Repository
{
    public class MBRepository : IMotherboard
    {
        private readonly AppDBContent appDBContent;
        public MBRepository(AppDBContent appDBContent) => this.appDBContent = appDBContent;
        public IEnumerable<Motherboard> AllMotherboards => appDBContent.MB.ToList();

        public Motherboard Motherboard(int Id) => appDBContent.MB.FirstOrDefault(c => c.Id == Id);
    }
}
