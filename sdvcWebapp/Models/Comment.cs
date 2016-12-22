using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Comment : BaseEntity
	{
		public int id { get; set; }
		public string content { get; set; }
		public int vso_id { get; set; }
		public VSO vso { get; set; }
		public int vet_id { get; set; }
		public Vet vet { get; set; }
		public int review_id { get; set; }
		public Review review { get; set; }
	}
}
