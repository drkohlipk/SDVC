using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Vet : BaseEntity
	{
		public int Vetid { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }
		public string email { get; set; }
		public string password { get; set; }
		public string phone { get; set; }
		public DateTime service_start { get; set; }
		public DateTime service_end { get; set; }
		public bool show_info { get; set; }
		public bool admin { get; set; }
		public int disability_rating { get; set; }
		public ICollection<Endorsement> Endorsements { get; set; }
		public Vet()
		{
			Endorsements = new List<Endorsement>();
		}
	}
}
