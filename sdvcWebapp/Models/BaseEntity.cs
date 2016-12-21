using System;
using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public abstract class BaseEntity 
	{
		public long id { get; set; }
		public DateTime created_at { get; set; }
		public DateTime updated_at { get; set; }
	}
}