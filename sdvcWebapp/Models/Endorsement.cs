namespace sdvcWebapp.Models
{
	public class Endorsement : BaseEntity
	{
		public int Endorsementid { get; set; }
		public int KWAttributeid { get; set; }
		public KWAttribute KWAttribute { get; set; }
		public int Vetid { get; set; }
		public Vet Vet { get; set; }
	}
}
