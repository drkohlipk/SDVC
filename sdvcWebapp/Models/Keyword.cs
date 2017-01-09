using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sdvcWebapp.Models
{
	public class Keyword : BaseEntity
	{
		public int Keywordid { get; set; }
		[MaxLengthAttribute(100)]
		[Required]
		public string kw { get; set; }
		public ICollection<KWAttribute> Attributes { get; set; }
		public Keyword()
		{
			Attributes = new List<KWAttribute>();
		}
	}
}
