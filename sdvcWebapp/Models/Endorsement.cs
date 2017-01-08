namespace sdvcWebapp.Models
{
	public class Endorsement : BaseEntity
	{
		public int vet_id { get; set; }
		public Vet vet { get; set; }
		public int attribute_id { get; set; }
		public Attribute attribute { get; set; }
	}
}
