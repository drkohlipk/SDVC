using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Service : BaseEntity
	{
		public int vet_id { get; set; }
		public Vet vet { get; set; }
		public int vso_id { get; set; }
		public VSO vso { get; set; }
	}
}
