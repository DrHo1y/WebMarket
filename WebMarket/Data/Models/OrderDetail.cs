using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Data.Models
{
    public class OrderDetail
    {
        public int Id { set; get; }
        public int OrderId { set; get; }
        public string VendorCode { set; get; }
        public int Price { set; get; }
        public virtual Order Order{ set; get; }
    }
}
