using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Data.Models
{
    public class Basket
    {
        private readonly AppDBContent appDBContent;
        public string Id { set; get; }
        public Basket(AppDBContent appDBContent) => this.appDBContent = appDBContent;
        public string StrId { set; get; }
        public virtual List<ProductItem> Products { set; get; }
        public static Basket GetCart(IServiceProvider services)
         {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string CartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", CartId);
            return new Basket(context) { StrId = CartId};
        
        }
        public void AddToCart(int product, int id)
        {
            try
            {
                var obj = appDBContent.GPU.Where(c => c.ProductRangeId == product).First(c =>c.Id == id);
                appDBContent.ProductItem.Add(
                    new ProductItem
                    {
                        Image = obj.Image,
                        Name = obj.Name,
                        Description = obj.Description,
                        Cost = obj.Cost,
                        IdProduct = obj.ProductRangeId
                    });
            }
            catch
            {

            }
            try
            {
                var obj = appDBContent.CPU.Where(c => c.ProductRangeId == product).First(c => c.Id == id);
                appDBContent.ProductItem.Add(
                    new ProductItem
                    {
                        Image = obj.Image,
                        Name = obj.Name,
                        Description = obj.Description,
                        Cost = obj.Cost,
                        IdProduct = obj.ProductRangeId
                    });
            }
            catch
            {

            }
            try
            {
                var obj = appDBContent.MB.Where(c => c.ProductRangeId == product).First(c => c.Id == id);
                appDBContent.ProductItem.Add(
                    new ProductItem
                    {
                        Image = obj.Image,
                        Name = obj.Name,
                        Description = obj.Description,
                        Cost = obj.Cost,
                        IdProduct = obj.ProductRangeId
                    });
            }
            catch
            {

            }
            appDBContent.SaveChanges();
        }
        public List<ProductItem> GetShopItems()
        {
            return appDBContent.ProductItem.Where(c => c.BasketId == Id).ToList(); //Include(x => x.BasketId).
        }
    }
}
