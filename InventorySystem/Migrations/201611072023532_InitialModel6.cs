namespace InventorySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Buyers", "MName", c => c.String(maxLength: 255));
            AlterColumn("dbo.Buyers", "LName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Buyers", "LName", c => c.String());
            AlterColumn("dbo.Buyers", "MName", c => c.String());
        }
    }
}
