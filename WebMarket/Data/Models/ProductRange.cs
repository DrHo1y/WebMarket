using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Data.Models
{
    public class ProductRange
    {
        public int Id { set; get; }

        [Required]
        [StringLength(25)]
        public string VendorCode { set; get; }
    }
}
