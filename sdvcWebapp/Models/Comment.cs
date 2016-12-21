using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Comment : BaseEntity
	{
		public string content { get; set; }
		public VSO vso { get; set; }
		public Vet vet { get; set; }
		public Review review { get; set; }
	}
}