using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.ViewModels.GPU;

namespace WebMarket.Controllers
{
    public class GPUController : Controller
    {
        private readonly IGPU _AllGPU;

        public GPUController(IGPU AllGPU)
        {
            _AllGPU = AllGPU;
        }
        [Route("GPU/List")]
        public ViewResult List()
        {
            var obj = new GPUListViewModel
            {
                GetAllGPU = _AllGPU.AllGPU
            };
            return View(obj);
        }
        [Route("GPU/Item")]
        [Route("GPU/Item/{Id}")]
        public ViewResult Item(int Id)
        {
            return View(_AllGPU.GPU(Id));
        }
    }
}
