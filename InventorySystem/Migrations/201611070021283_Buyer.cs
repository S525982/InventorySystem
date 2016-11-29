namespace InventorySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Buyer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sellers", "LocationId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sellers", "LocationId");
        }
    }
}
