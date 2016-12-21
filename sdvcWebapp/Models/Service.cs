using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Service : BaseEntity
	{
		public Vet vet { get; set; }
		public VSO vso { get; set; }
	}
}