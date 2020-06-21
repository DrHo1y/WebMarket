using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Data.Models
{
    public class Motherboard : BaseClass
    {
        [Required]
        [StringLength(6)]
        public string ProcessorSupport { set; get; }

        [Required]
        [StringLength(15)]
        public string Socket { set; get; }

        [Required]
        [StringLength(20)]
        public string Chipset { set; get; }

        [Required]
        [StringLength(10)]
        public string FormFactor { set; get; }

        [Required]
        public bool Backlight { set; get; }

        [Required]
        [StringLength(10)]
        public string MemoryType { set; get; }

        [Required]
        [StringLength(2)]
        public byte MemorySlots { set; get; }

        [Required]
        [StringLength(8)]
        public string MaxMemoryCapacity { set; get; }

        [Required]
        [StringLength(30)]
        public string MemoryMode { set; get; }

        [Required]
        [StringLength(10)]
        public string MaxMemoryFrequency { set; get; }
    }
}
