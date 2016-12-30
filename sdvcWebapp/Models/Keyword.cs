using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Keyword : BaseEntity
	{
		public string Text { get; set; }
		public ICollection<Endorsement> Endorsements { get; set; }
		public Keyword()
		{
			endorsements = new List<Endorsement>();
		}
	}
}
