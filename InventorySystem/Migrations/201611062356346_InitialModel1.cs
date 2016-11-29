namespace InventorySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "city", c => c.String());
            AddColumn("dbo.Locations", "zipcode", c => c.Int(nullable: false));
            AddColumn("dbo.Locations", "phone", c => c.Int(nullable: false));
            AddColumn("dbo.Locations", "email", c => c.String());
            AddColumn("dbo.Sellers", "MName", c => c.String());
            AddColumn("dbo.Sellers", "LName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sellers", "LName");
            DropColumn("dbo.Sellers", "MName");
            DropColumn("dbo.Locations", "email");
            DropColumn("dbo.Locations", "phone");
            DropColumn("dbo.Locations", "zipcode");
            DropColumn("dbo.Locations", "city");
        }
    }
}
