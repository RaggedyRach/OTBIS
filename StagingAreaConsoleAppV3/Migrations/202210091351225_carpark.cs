namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carpark : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarParks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParkingNode = c.String(),
                        TicketNumber = c.String(),
                        NumberPlate = c.String(),
                        MediaType = c.String(),
                        EntryDateTime = c.DateTime(nullable: false),
                        PNLaneEntryStation = c.String(),
                        LaneEntryStation = c.String(),
                        PaymentDateTime = c.DateTime(),
                        PaymentDeviceParkingNode = c.String(),
                        PaymentDevice = c.String(),
                        Currency = c.String(),
                        Fee = c.Double(),
                        Validation = c.Double(),
                        Net = c.Double(),
                        Taxes = c.Double(),
                        ReceiptId = c.String(),
                        ExitDateTime = c.DateTime(),
                        ParkingNodeLaneExit = c.String(),
                        LaneExitStation = c.String(),
                        StayTime = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarParks");
        }
    }
}
