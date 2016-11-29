namespace InventorySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Code = c.String(),
                        Size = c.String(),
                        Color = c.String(),
                        Quantity = c.Int(nullable: false),
                        Comment = c.String(),
                        SellerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Sellers", t => t.SellerId, cascadeDelete: true)
                .Index(t => t.SellerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "SellerId", "dbo.Sellers");
            DropIndex("dbo.Products", new[] { "SellerId" });
            DropTable("dbo.Products");
        }
    }
}
