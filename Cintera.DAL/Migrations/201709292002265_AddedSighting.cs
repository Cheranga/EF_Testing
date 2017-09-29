namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSighting : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sighting",
                c => new
                    {
                        SightingId = c.Int(nullable: false, identity: true),
                        CaseId = c.Int(nullable: false),
                        Address = c.String(nullable: false, maxLength: 256),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SightingId)
                .ForeignKey("dbo.Case", t => t.CaseId, cascadeDelete: true)
                .Index(t => t.CaseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sighting", "CaseId", "dbo.Case");
            DropIndex("dbo.Sighting", new[] { "CaseId" });
            DropTable("dbo.Sighting");
        }
    }
}
