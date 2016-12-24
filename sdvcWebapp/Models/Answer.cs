
namespace sdvcWebapp.Models
{
	public class Answer : BaseEntity
	{
		public string a { get; set; }
		public int vet_id { get; set; }
		public Vet vet { get; set; }
		public int question_id { get; set; }
		public Question question { get; set; }
	}
}
