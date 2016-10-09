namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDnsLab : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DnsLab",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.DnsSample", "DnsLabId", c => c.Int(nullable: false));
            CreateIndex("dbo.DnsSample", "DnsLabId");
            AddForeignKey("dbo.DnsSample", "DnsLabId", "dbo.DnsLab", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DnsSample", "DnsLabId", "dbo.DnsLab");
            DropIndex("dbo.DnsSample", new[] { "DnsLabId" });
            DropColumn("dbo.DnsSample", "DnsLabId");
            DropTable("dbo.DnsLab");
        }
    }
}
