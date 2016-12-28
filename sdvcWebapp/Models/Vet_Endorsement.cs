namespace sdvcWebapp.Models
{
	public class Vet_Endorsement : BaseEntity
	{
		public int vet_id { get; set; }
		public Vet vet { get; set; }
		public int endorsement_id { get; set; }
		public Endorsement endorsements { get; set; }
	}
}