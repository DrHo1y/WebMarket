using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.ViewModels.CPU;

namespace WebMarket.Controllers
{
    public class CPUController : Controller
    {
        private readonly ICPU _AllCPU;
        public CPUController(ICPU iCPU)
        {
            _AllCPU = iCPU;
        }
        [Route("CPU/List")]
        public ViewResult List()
        {
            CPUListViewModel obj = new CPUListViewModel
            {
                GetAllCPU = _AllCPU.GetCPUs
            };
            return View(obj);
        }
        [Route("CPU/Item")]
        [Route("CPU/Item/{Id}")]
        public ViewResult Item(int Id)
        { 
            return View(_AllCPU.GetCPU(Id));
        }
    }
}
