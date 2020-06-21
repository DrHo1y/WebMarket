using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Models;

namespace WebMarket.Data.Repository
{
    public class GPURepository : IGPU
    {
        private readonly AppDBContent appDBContent;
        public GPURepository(AppDBContent appDBContent) => this.appDBContent = appDBContent;
        public IEnumerable<GraphicalCard> AllGPU => appDBContent.GPU.ToList();

        public GraphicalCard GPU(int Id) => appDBContent.GPU.FirstOrDefault(c => c.Id == Id);
    }
}
