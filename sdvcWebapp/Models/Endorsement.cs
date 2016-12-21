using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Endorsement : BaseEntity
	{
		public VSO vso { get; set; }
		public Vet vet { get; set; }
		public Keyword keyword { get; set; }
	}
}