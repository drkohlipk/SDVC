using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Vet : BaseEntity
	{
		public string first_name { get; set; }
		public string last_name { get; set; }
		public string email { get; set; }
		public string password { get; set; }
		public string phone { get; set; }
		public Date service_start { get; set; }
		public Date service_end { get; set; }
		public bool show_info { get; set; }
		public bool admin { get; set; }
		public int disability_rating { get; set; }
		public int branch_id { get; set; }
		public Branch branch { get; set; }
		public ICollection<Answer> answers { get; set; }
		public ICollection<VSO> approvals { get; set; }
		public ICollection<Review> reviews { get; set; }
		public ICollection<Comment> comments { get; set; }
		public ICollection<Service> services { get; set; }
		public ICollection<Endorsement> endorsements { get; set; }
		public ICollection<Donation> donations { get; set; }
		public ICollection<Login> logins { get; set; }
		public Vet()
		{
			answers = new List<Answer>();
			approvals = new List<Approvals>();
			reviews = new List<Review>();
			comments = new List<Comment>();
			services = new List<Service>();
			endorsements = new List<Endorsement>();
			donations = new List<Donation>();
			logins = new List<Login>();
		}
	}
}
