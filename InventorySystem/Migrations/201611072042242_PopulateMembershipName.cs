namespace InventorySystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes set Name='Pay  you go' where id=1");
            Sql("UPDATE MembershipTypes set Name='Monthly' where id=2");
            Sql("UPDATE MembershipTypes set Name='Quarterly' where id=3");
            Sql("UPDATE MembershipTypes set Name='Yearly' where id=4");
        }
        
        public override void Down()
        {
        }
    }
}
