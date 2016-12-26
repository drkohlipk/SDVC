using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Status : BaseEntity
	{
		public int id { get; set; }
		public string img { get; set; }
		public ICollection<VSO> vsos { get; set; }
		public Status()
		{
			vsos = new List<VSO>();
		}
	}
}
