using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMarket.Data.Interfaces;
using WebMarket.Data.Models;

namespace WebMarket.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly Basket basket;

        public OrdersRepository(AppDBContent appDBContent, Basket basket)
        {
            this.appDBContent = appDBContent;
            this.basket = basket;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            var items = basket.Products;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    Price = el.Cost,
                    //OrderId = order.Id,
                    VendorCode = appDBContent.ProductRange.Where(x => x.Id == el.IdProduct).FirstOrDefault().VendorCode
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}
//SqlException: The MERGE statement conflicted with the FOREIGN KEY constraint 
//"FK_OrderDetail_Order_OrderId". The conflict occurred in database "MvcWebMarketContext-1", table "dbo.Order", column 'Id'.
//Вызвано исключение: "Microsoft.EntityFrameworkCore.DbUpdateException" в Microsoft.EntityFrameworkCore.dll
//Исключение типа "Microsoft.EntityFrameworkCore.DbUpdateException" возникло в Microsoft.EntityFrameworkCore.dll, но не было обработано в коде пользователя
//An error occurred while updating the entries.See the inner exception for details.