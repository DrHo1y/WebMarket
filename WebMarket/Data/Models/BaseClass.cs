using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Data.Models
{
    public class BaseClass
    {
        public int Id { set; get; }

        [Required]
        [StringLength(100)]
        public string Name { set; get; }

        public string Image { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { set; get; }

        [Required]
        public string MarketEntryDate { set; get; }

        [Column(TypeName = "decimal(7,2)")]
        public int Cost { set; get; }
        public int ProductRangeId { set; get; }
        public virtual ProductRange ProductRange { set; get; }
    }
}
