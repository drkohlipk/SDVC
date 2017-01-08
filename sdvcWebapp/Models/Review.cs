using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Review : BaseEntity
	{
		public int rating { get; set; }
		public string content { get; set; }
		public int vet_id { get; set; }
		public Vet vet { get; set; }
		public int vso_id { get; set; }
		public VSO vso { get; set; }
		public ICollection<Comment> comments { get; set; }
		public Review()
		{
			comments = new List<Comment>();
		}
	}
}