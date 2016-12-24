using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class State : BaseEntity
	{
		public string name { get; set; }
		public ICollection<City> cities { get; set; }
		public State()
		{
			cities = new List<City>();
		}
	}
}
