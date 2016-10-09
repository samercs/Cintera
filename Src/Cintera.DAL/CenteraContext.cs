using System.ComponentModel.DataAnnotations.Schema;
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
            modelBuilder.Entity<Vehicle>().Property(i => i.VehicleIdentitficationNumber).HasMaxLength(17).IsRequired();
            modelBuilder.Entity<Sighting>().Property(i => i.Address).HasMaxLength(256).IsRequired();
            modelBuilder.Entity<DnsSampleStatus>()
                .Property(i => i.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<DnsSampleStatus>()
                .Property(i => i.Name)
                .HasMaxLength(10)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<Case> Cases { get; set; }
        public IDbSet<DnsSample> DnsSamples { get; set; }
    }
}
