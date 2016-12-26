using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Question : BaseEntity
	{
		public int id { get; set; }
		public string q { get; set; }
		public ICollection<Answer> answers { get; set; }
		public Question()
		{
			answers = new List<Answer>();
		}
	}
}
