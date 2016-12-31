using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Keyword : BaseEntity
	{
		public string Text { get; set; }
		public ICollection<Endorsement> endorsements { get; set; }
		public Keyword()
		{
			endorsements = new List<Endorsement>();
		}
	}
}
