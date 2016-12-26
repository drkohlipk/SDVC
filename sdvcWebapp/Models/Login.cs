
namespace sdvcWebapp.Models
{
	public class Login : BaseEntity
	{
		public int id { get; set; }
		public int vso_id { get; set; }
		public VSO vso { get; set; }
		public int vet_id { get; set; }
		public Vet vet { get; set; }
	}
}
