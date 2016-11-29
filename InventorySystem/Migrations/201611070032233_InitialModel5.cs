namespace InventorySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel5 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Buyers", "LocationId");
            CreateIndex("dbo.Sellers", "LocationId");
            AddForeignKey("dbo.Buyers", "LocationId", "dbo.Locations", "id", cascadeDelete: true);
            AddForeignKey("dbo.Sellers", "LocationId", "dbo.Locations", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sellers", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Buyers", "LocationId", "dbo.Locations");
            DropIndex("dbo.Sellers", new[] { "LocationId" });
            DropIndex("dbo.Buyers", new[] { "LocationId" });
        }
    }
}
