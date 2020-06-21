using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Data.Models
{
	public class Processor : BaseClass
	{
		[Required]
		[StringLength(15)]
		public string Socket { set; get; }

		[Required]
		[StringLength(6)]
		public byte NumberCores { set; get; }

		[Required]
		[StringLength(6)]
		public byte MaximumNumberThreads { set; get; }

		[Required]
		[StringLength(15)]
		public string Baseclock { set; get; }

		[Required]
		[StringLength(10)]
		public string MaximumFrequency { set; get; }

		[Required]
		[StringLength(6)]
		public string L2cache { set; get; }

		[Required]
		[StringLength(6)]
		public string L3cache { set; get; }

		[Required]
		[StringLength(6)]
		public string MemorySupport { set; get; }

		[Required]
		[StringLength(2)]
		public string NumberOfChannels { set; get; }

		[Required]
		[StringLength(10)]
		public string MaxMemoryFrequency { set; get; }
	}
}
