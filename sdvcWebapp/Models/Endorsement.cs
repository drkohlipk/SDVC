using System.Collections.Generic;

namespace sdvcWebapp.Models
{
	public class Endorsement
	{
		public int Endorsementid { get; set; }
		public int Attributeid { get; set; }
		public KWAttribute Attribute { get; set; }
		public int Vetid { get; set; }
		public Vet Vet { get; set; }
	}
}
