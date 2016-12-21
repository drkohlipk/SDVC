using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Donation_Type : BaseEntity
	{
		public string name { get; set; }
		public ICollections<Donation> donations { get; set; }
		public Donation_Type()
		{
			donations = new List<Donation>();
		}
	}
}