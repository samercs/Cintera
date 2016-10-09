namespace Cintera.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddView1 : DbMigration
    {
        public override void Up()
        {

            Sql(Script.AddView1);
        }

        public override void Down()
        {
            Sql("drop view V_View1");
        }
    }
}
