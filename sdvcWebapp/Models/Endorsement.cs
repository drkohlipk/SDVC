using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Endorsement : BaseEntity
	{
		public int id { get; set; }
		public int vso { get; set; }
		public VSO vso { get; set; }
		public int vet { get; set; }
		public Vet vet { get; set; }
		public int keyword_id { get; set; }
		public Keyword keyword { get; set; }
	}
}
