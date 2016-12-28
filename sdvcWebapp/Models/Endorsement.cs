using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Endorsement : BaseEntity
	{
		public int vso_id { get; set; }
		public VSO vso { get; set; }
		public int keyword_id { get; set; }
		public Keyword keyword { get; set; }
		public ICollection<Vet> vets { get; set; }
		public Endorsement()
		{
			vets = new List<Vet>();
		}
	}
}
