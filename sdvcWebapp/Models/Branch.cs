using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Branch : BaseEntity
	{
		public string name { get; set; }
		public string img { get; set; }
		public ICollections<Vet> vets { get; set; }
		public Branch()
		{
			vets = new List<Vet>();
		}
	}
}