namespace Cintera.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RenameCaseTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sighting", "CaseId", "dbo.Case");
            DropForeignKey("dbo.Vehicle", "CaseId", "dbo.Case");
            DropIndex("dbo.Sighting", new[] { "CaseId" });
            DropIndex("dbo.Vehicle", new[] { "CaseId" });

            RenameColumn("Case", "CaseId", "InvistigationId");
            RenameTable("Case", "Invistigation");
            RenameColumn("Sighting", "CaseId", "InvistigationId");
            RenameColumn("Vehicle", "CaseId", "InvistigationId");

            CreateIndex("dbo.Sighting", "InvistigationId");
            CreateIndex("dbo.Vehicle", "InvistigationId");
            AddForeignKey("dbo.Sighting", "InvistigationId", "dbo.Invistigation", "InvistigationId", cascadeDelete: true);
            AddForeignKey("dbo.Vehicle", "InvistigationId", "dbo.Invistigation", "InvistigationId", cascadeDelete: true);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Sighting", "InvistigationId", "dbo.Invistigation");
            DropForeignKey("dbo.Vehicle", "InvistigationId", "dbo.Invistigation");
            DropIndex("dbo.Sighting", new[] { "InvistigationId" });
            DropIndex("dbo.Vehicle", new[] { "InvistigationId" });

            RenameColumn("Invistigation", "InvistigationId", "CaseId");
            RenameTable("Invistigation", "Case");
            RenameColumn("Sighting", "InvistigationId", "CaseId");
            RenameColumn("Vehicle", "InvistigationId", "CaseId");

            CreateIndex("dbo.Sighting", "CaseId");
            CreateIndex("dbo.Vehicle", "CaseId");
            AddForeignKey("dbo.Sighting", "CaseId", "dbo.case", "CaseId", cascadeDelete: true);
            AddForeignKey("dbo.Vehicle", "CaseId", "dbo.case", "CaseId", cascadeDelete: true);
        }
    }
}
