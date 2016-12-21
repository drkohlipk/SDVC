using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Donation : BaseEntity
	{
		public double amount { get; set; }
		public string donor { get; set; }
		public string donor_info { get; set; }
		public int type_id { get; set; }
		public Donation_Type donation_type { get; set; }
		public int vso_id { get; set; }
		public VSO vso { get; set; }
		public int vet_id { get; set; }
		public Vet vet { get; set; }
	}
}
