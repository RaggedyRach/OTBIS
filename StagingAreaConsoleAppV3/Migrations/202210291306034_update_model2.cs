namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_model2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.W5Booking", "Actual_Visit_till_no", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.W5Booking", "Actual_Visit_till_no");
        }
    }
}
