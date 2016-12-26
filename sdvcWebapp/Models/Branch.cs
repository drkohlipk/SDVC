using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Branch : BaseEntity
	{
		public int id { get; set; }
		public string name { get; set; }
		public string img { get; set; }
		public ICollection<Vet> vets { get; set; }
		public Branch()
		{
			vets = new List<Vet>();
		}
	}
}
