using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace sdvcWebapp.Models
{
    public class SDVCContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string Server = "localhost";
            string Port = "3306"; //or 8889 on Mac
            string Database = "sdvcWebapp";
            string UserId = "root";
            string Password = "root";
            string Connection = $"Server={Server};port={Port};database={Database};uid={UserId};pwd={Password};SslMode=None;";
            optionsBuilder.UseMySQL(Connection);
        }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Endorsement> Endorsements { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<VSO> Vsos { get; set; }

    }
}