﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {

        }
        public ViewResult Index()
        {
            return View();
        }
    }
}
