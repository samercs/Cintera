namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DAL.Enum;

    internal sealed class Configuration : DbMigrationsConfiguration<Cintera.DAL.CenteraContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Cintera.DAL.CenteraContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.DnsSampleStatuses.AddOrUpdate(i => i.Id, Enum.GetValues(typeof(DnsSampleStatusEnum)).Cast<DnsSampleStatusEnum>().Select(i => new DnsSampleStatus
            {
                Id = i,
                Name = i.ToString()
            }).ToArray());
        }
    }
}
