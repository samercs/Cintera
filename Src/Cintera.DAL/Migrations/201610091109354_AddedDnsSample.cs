namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDnsSample : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DnsSample",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SampleStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DnsSampleStatus", t => t.SampleStatusId, cascadeDelete: true)
                .Index(t => t.SampleStatusId);
            
            CreateTable(
                "dbo.DnsSampleStatus",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DnsSample", "SampleStatusId", "dbo.DnsSampleStatus");
            DropIndex("dbo.DnsSample", new[] { "SampleStatusId" });
            DropTable("dbo.DnsSampleStatus");
            DropTable("dbo.DnsSample");
        }
    }
}
