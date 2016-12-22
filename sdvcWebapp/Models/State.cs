using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class State : BaseEntity
	{
		public int id { get; set; }
		public string name { get; set; }
		public ICollections<City> cities { get; set; }
		public State()
		{
			cities = new List<City>();
		}
	}
}
