namespace Cintera.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RenameIdOnDnsLab : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.DnsLab", "Id", "DnsLabId");
        }

        public override void Down()
        {
            RenameColumn("dbo.DnsLab", "DnsLabId", "Id");
        }
    }
}
