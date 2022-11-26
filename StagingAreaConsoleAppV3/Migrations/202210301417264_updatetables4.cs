namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetables4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.W5Membership", "DateJoined", c => c.DateTime());
            AlterColumn("dbo.W5Membership", "ExpiryDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.W5Membership", "ExpiryDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.W5Membership", "DateJoined", c => c.DateTime(nullable: false));
        }
    }
}
