namespace InventorySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationstoBuyerFName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Buyers", "FName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Buyers", "FName", c => c.String());
        }
    }
}
