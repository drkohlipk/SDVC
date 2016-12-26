using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Donation_Type : BaseEntity
	{
		public int id { get; set; }
		public string name { get; set; }
		public ICollection<Donation> donations { get; set; }
		public Donation_Type()
		{
			donations = new List<Donation>();
		}
	}
}
