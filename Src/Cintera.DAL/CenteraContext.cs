using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Cintera.DAL
{
    public class CenteraContext : IdentityDbContext<ApplicationUser>, ICerteraContext
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

            modelBuilder.Entity<DnsLab>().Property(i => i.Name).IsRequired().HasMaxLength(50);

            modelBuilder.Entity<Region>().Property(i => i.Name).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<Region>().HasOptional(i => i.Parent).WithMany().HasForeignKey(i => i.ParentId);
            modelBuilder.Entity<View1>().ToTable("V_View1").HasKey(x => new { x.Id });

            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<Case> Cases { get; set; }
        public IDbSet<DnsSample> DnsSamples { get; set; }
        public IDbSet<DnsSampleStatus> DnsSampleStatuses { get; set; }
        public IDbSet<Region> Regions { get; set; }
        public IDbSet<View1> View1 { get; set; }

        public static CenteraContext Create()
        {
            return new CenteraContext();
        }
    }
}
