using System.Collections.Generic;

namespace sdvcWebapp.Models
{
    public class Attribute : BaseEntity
    {
        public int Keyword_Id { get; set; }
        public int Vso_Id { get; set; }
        public ICollection<VSO> VSOs {get; set;}
        public ICollection<Keyword> Keywords { get; set; }

    }
}