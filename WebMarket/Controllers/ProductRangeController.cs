using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.ViewModels.PRange;

namespace WebMarket.Controllers
{
    public class ProductRangeController : Controller
    {
        private readonly IProductRange _AllPRange;
        public ProductRangeController(IProductRange iPRange)
        {
            _AllPRange = iPRange;
        }
        public ViewResult List()
        {
            PRangeListViewModel obj = new PRangeListViewModel
            {
                GetAllPRange = _AllPRange.GetProducts
            };
            return View(obj);
        }
        public ViewResult Item(int id = 1)
        {
            PRangeItemViewModel obj = new PRangeItemViewModel
            {
                GetPRange = _AllPRange.GetProduct(id)
            };
            return View(obj);
        }
    }
}
