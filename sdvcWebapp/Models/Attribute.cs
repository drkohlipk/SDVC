namespace sdvcWebapp.Models
{
	public class Attribute : BaseEntity
	{
		public int vso_id { get; set; }
		public VSO vso { get; set; }
		public int keyword_id { get; set; }
		public Keyword keyword { get; set; }
	}
}
