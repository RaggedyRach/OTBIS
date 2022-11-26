namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_model : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.W5Booking", "Actual_Visit_Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.W5Booking", "Actual_Visit_Date", c => c.DateTime(nullable: false));
        }
    }
}
