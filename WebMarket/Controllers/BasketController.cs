using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Models;
using WebMarket.Data.Repository;
using WebMarket.ViewModels.Cart;

namespace WebMarket.Controllers
{
    public class BasketController : Controller
    {
        private readonly Basket _Cart;

        public BasketController(Basket cart)
        {
            _Cart = cart;
        }
        public ViewResult Index()
        {
            var items = _Cart.GetShopItems();
            _Cart.Products = items;
            var obj = new BasketIndexViewModel
            {
                shopCart = _Cart
            };
            return View(obj);
        }
        public RedirectToActionResult AddToCart(int idProductRange, int id)
        {
            _Cart.AddToCart(idProductRange, id);
            return RedirectToAction("Index");
        }
    }
}
