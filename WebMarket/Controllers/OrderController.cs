using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Models;

namespace WebMarket.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly Basket basket;
        public static IServiceProvider Services;

        public OrderController(IAllOrders allOrders, Basket basket)
        {
            this.allOrders = allOrders;
            this.basket = basket;
        }
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            basket.Products = basket.GetShopItems();
            if(basket.Products.Count == 0)
            {
                ModelState.AddModelError("", "В корзине должны быть товары!");
            }
            if(ModelState.IsValid)
            {
                allOrders.CreateOrder(order);
                return RedirectToAction("Complite");
            }
            return View(order);
        }

        public IActionResult Complite()
        {
            ViewBag.Message = "Готово";
            return View();
        }
    }
}
