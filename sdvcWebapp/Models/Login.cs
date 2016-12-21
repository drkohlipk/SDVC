using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Login : BaseEntity
	{
		public VSO vso { get; set; }
		public Vet vet { get; set; }
	}
}