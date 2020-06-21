using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.ViewModels.MB;

namespace WebMarket.Controllers
{
    public class MBController : Controller
    {
        private readonly IMotherboard _AllMB;
        public MBController(IMotherboard AllMB)
        {
            _AllMB = AllMB;
        }
        [Route("MB/List")]
        public ViewResult List()
        {
            var obj = new MBListViewModel
            {
                GetAllMB = _AllMB.AllMotherboards
            };
            return View(obj);
        }
        [Route("MB/Item")]
        [Route("MB/Item/{Id}")]
        public ViewResult Item(int Id)
        {
            return View(_AllMB.Motherboard(Id));
        }
    }
}
