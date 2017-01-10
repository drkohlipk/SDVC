using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class VSO : BaseEntity
	{
		public int Vsoid { get; set; }
		public string name { get; set; }
		public string headline { get; set; }
		public string description { get; set; }
		public string img { get; set; }
		public string poc_name { get; set; }
		public string poc_phone { get; set; }
		public string poc_email { get; set; }
		public string address_1 { get; set; }
		public string address_2 { get; set; }
		public string emer_phone { get; set; }
		public int disability_rate { get; set; }
		public bool approved { get; set; }
		public string verifier_name { get; set; }
		public string verifier_email { get; set; }
		public string website { get; set; }
		public string password { get; set; }
		public ICollection<KWAttribute> attributes { get; set; }
		public VSO()
		{
			attributes = new List<KWAttribute>();
		}
	}
}
