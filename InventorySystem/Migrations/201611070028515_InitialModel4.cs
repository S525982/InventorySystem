namespace InventorySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        BuyerId = c.Int(nullable: false, identity: true),
                        FName = c.String(),
                        MName = c.String(),
                        LName = c.String(),
                        Verified = c.Boolean(nullable: false),
                        MembershipTypeId = c.Byte(nullable: false),
                        LocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BuyerId)
                .ForeignKey("dbo.MembershipTypes", t => t.MembershipTypeId, cascadeDelete: true)
                .Index(t => t.MembershipTypeId);
            
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Short(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        DiscountRate = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buyers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Buyers", new[] { "MembershipTypeId" });
            DropTable("dbo.MembershipTypes");
            DropTable("dbo.Buyers");
        }
    }
}
