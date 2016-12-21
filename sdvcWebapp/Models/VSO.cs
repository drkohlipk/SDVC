using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class VSO : BaseEntity
	{
		public string name { get; set; }
		public string headline { get; set; }
		public string description { get; set; }
		public string image { get; set; }
		public string poc_name { get; set; }
		public string poc_phone { get; set; }
		public string poc_email { get; set; }
		public string address_1 { get; set; }
		public string address_2 { get; set; }
		public string emer_phone { get; set; }
		public int disability_rating { get; set; }
		public bool approved { get; set; }
		public string verifier_name { get; set; }
		public string verifier_phone { get; set; }
		public string verifier_email { get; set; }
		public string website { get; set; }
		public string password { get; set; }
		public Vet approver_id { get; set; }
		public Status status_id { get; set; }
		public Zip zip_id { get; set; }
		public ICollection<Review> reviews { get; set; }
		public ICollection<Comment> comments { get; set; }
		public ICollection<Service> services { get; set; }
		public ICollection<Endorsement> endorsements { get; set; }
		public ICollection<Donation> donations { get; set; }
		public ICollection<Login> logins { get; set; }
		public VSO() 
		{
			reviews = new List<Review>();
			comments = new List<Comment>();
			services = new List<Service>();
			endorsements = new List<Endorsement>();
			donations = new List<Donation>();
			logins = new List<Login>();
		}
	}
}