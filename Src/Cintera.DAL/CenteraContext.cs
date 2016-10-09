using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Cintera.DAL
{
    public class CenteraContext : DbContext
    {
        public CenteraContext() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Sighting>().Property(i => i.Address).HasMaxLength(256).IsRequired();
            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<Case> Cases { get; set; }
    }
}
