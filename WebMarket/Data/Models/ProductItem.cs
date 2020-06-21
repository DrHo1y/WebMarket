using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Data.Models
{
    public class ProductItem
    {
        public int Id { set; get; }
        public string BasketId { set; get; }
        public string Image { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public int Cost { set; get; }
        public int IdProduct { set; get; }
        public virtual ProductRange Products { set; get; }
    }
}
