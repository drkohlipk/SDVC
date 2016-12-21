using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Answer : BaseEntity
	{
		public string a { get; set; }
		public Vet vet { get; set; }
		public Question question { get; set; }
	}
}