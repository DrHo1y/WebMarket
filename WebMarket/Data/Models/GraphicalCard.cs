using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Data.Models
{
	public class GraphicalCard : BaseClass
	{
		[Required]
		[StringLength(20)]
		public string Interface { set; get; }

		[Required]
		[StringLength(6)]
		public string Manufacturer { set; get; }

		[Required]
		[StringLength(30)]
		public string GPU { set; get; }

		[Required]
		public bool OverclockedVersion { set; get; }

		[Required]
		[StringLength(10)]
		public string Frequency { set; get; }

		[StringLength(10)]
		public string TurboFrequency { set; get; }

		public int NumberOfStreamProcessors { set; get; }

		[Required]
		[StringLength(10)]
		public string VideoMemory { set; get; }

		[Required]
		[StringLength(10)]
		public string TypeMemory { set; get; }

		[Required]
		[StringLength(10)]
		public string MemoryFrequency { set; get; }

		public int MemoryBusWidth { set; get; }
	}
}
