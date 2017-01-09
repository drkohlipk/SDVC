using System.Collections.Generic;

namespace sdvcWebapp.Models
{
    public class KWAttribute : BaseEntity
    {
        public int KWAttributeid { get; set; }
        public int Keywordid { get; set; }
        public int Vsoid { get; set; }
        public VSO VSO {get; set;}
        public Keyword Keyword { get; set; }
        public ICollection<Endorsement> Endorsements { get; set; }
        public KWAttribute()
        {
            Endorsements = new List<Endorsement>();
        }
    }
}