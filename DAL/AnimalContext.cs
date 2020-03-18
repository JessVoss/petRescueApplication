using petRescueApplication.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace petRescueApplication.DAL
{
    public class AnimalContext : DbContext
    {

        public AnimalContext() : base("AnimalContext")
        {
        }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}