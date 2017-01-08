using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sdvcWebapp.Models
{
	public class Keyword : BaseEntity
	{
		[MaxLengthAttribute(100)]
		[Required]
		public string kw { get; set; }
		public ICollection<Endorsement> endorsements { get; set; }
		public Keyword()
		{
			endorsements = new List<Endorsement>();
		}
	}
}
