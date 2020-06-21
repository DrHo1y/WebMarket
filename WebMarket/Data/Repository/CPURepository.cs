using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Models;

namespace WebMarket.Data.Repository
{
    public class CPURepository : ICPU
    {
        private readonly AppDBContent appDBContent;
        public CPURepository(AppDBContent appDBContent) => this.appDBContent = appDBContent;
        public IEnumerable<Processor> GetCPUs => appDBContent.CPU.ToList();

        public Processor GetCPU(int Id) => appDBContent.CPU.FirstOrDefault(c =>c.Id == Id);
    }
}
