namespace Cintera.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeededRegions : DbMigration
    {
        public override void Up()
        {
            Sql(Script.CountryByState);
            Sql(Script.InsertRegion);
        }

        public override void Down()
        {
            Sql("delete from region");
        }
    }
}
