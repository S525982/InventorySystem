namespace InventorySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel7 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Code", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Size", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Color", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Comment", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Comment", c => c.String());
            AlterColumn("dbo.Products", "Color", c => c.String());
            AlterColumn("dbo.Products", "Size", c => c.String());
            AlterColumn("dbo.Products", "Code", c => c.String());
            AlterColumn("dbo.Products", "Type", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
    }
}
