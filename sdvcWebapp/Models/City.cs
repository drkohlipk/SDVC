using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class City : BaseEntity
	{
		public string name { get; set; }
		public State state { get; set; }
		public ICollections<Zipcode> zipcodes { get; set; }
		public City()
		{
			zipcodes = new List<Zipcode>();
		}
	}
}