using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Zipcode : BaseEntity
	{
		public int code { get; set; }
		public int code2 { get; set; }
		public City city { get; set; }
		public ICollections<VSO> vsos { get; set; }
		public Zipcode()
		{
			vsos = new List<VSO>();
		}
	}
}