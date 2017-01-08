
using Microsoft.EntityFrameworkCore;
using sdvcWebapp.Models;

namespace sdvcWebapp.Infrastructure
{
    public class SDVCContext: DbContext
    {
        public SDVCContext(DbContextOptions<SDVCContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
      public  DbSet<Attribute> Attributes {get; set;}
      public   DbSet<Endorsement> Endorsements {get; set;}
       public  DbSet<Keyword> Keywords {get; set;}
       public  DbSet<Vet> Vets {get; set;}
       public  DbSet<VSO> VSOs {get; set;}
    }
}