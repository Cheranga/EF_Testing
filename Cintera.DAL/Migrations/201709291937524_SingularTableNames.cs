namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SingularTableNames : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cases", newName: "Case");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Case", newName: "Cases");
        }
    }
}
