namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_model1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.W5Booking", "Booked_Date", c => c.DateTime());
            AlterColumn("dbo.W5Booking", "First_Payment_Received", c => c.DateTime());
            AlterColumn("dbo.W5Booking", "Booking_Visit_Date", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.W5Booking", "Booking_Visit_Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.W5Booking", "First_Payment_Received", c => c.DateTime(nullable: false));
            AlterColumn("dbo.W5Booking", "Booked_Date", c => c.DateTime(nullable: false));
        }
    }
}
