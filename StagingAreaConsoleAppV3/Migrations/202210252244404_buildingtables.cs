namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class buildingtables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ArenaEventAudits",
                c => new
                    {
                        ArenaEventAuditId = c.Int(nullable: false, identity: true),
                        EventTitle = c.String(),
                        EventCode = c.String(),
                        DataAsAt = c.DateTime(nullable: false),
                        TotalTickets = c.Int(nullable: false),
                        NetCapacity = c.Int(nullable: false),
                        RetailAvailability = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalFaceValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Potential = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Sold = c.Int(nullable: false),
                        SoldPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Comps = c.Int(nullable: false),
                        CompsPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrePrints = c.Int(nullable: false),
                        PrePrintsPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Holds = c.Int(nullable: false),
                        HoldsPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Opens = c.Int(nullable: false),
                        OpensPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Inquiry = c.Int(nullable: false),
                        InquiryPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalTicketsSoldToday = c.Int(nullable: false),
                        TotalFaceValueToday = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ArenaEventAuditId);
            
            CreateTable(
                "dbo.ArenaEventCapacities",
                c => new
                    {
                        ArenaCapacityId = c.Int(nullable: false, identity: true),
                        Inventory = c.String(),
                        TotalTickets = c.Int(nullable: false),
                        GA = c.Int(nullable: false),
                        Price1 = c.Int(nullable: false),
                        Price2 = c.Int(nullable: false),
                        Disa = c.Int(nullable: false),
                        six = c.Int(nullable: false),
                        seven = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArenaCapacityId);
            
            CreateTable(
                "dbo.ArenaEventSummaryPriceLevels",
                c => new
                    {
                        ArenaEventSummaryPriceLevelId = c.Int(nullable: false, identity: true),
                        PriceLevelName = c.String(),
                        NetCapacity = c.Int(nullable: false),
                        TotalTickets = c.Int(nullable: false),
                        TotalFaceValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PercentDistributed = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PercentNetCapacity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RetailAvailibiltyPercent = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ArenaEventSummaryPriceLevelId);
            
            CreateTable(
                "dbo.CompTypes",
                c => new
                    {
                        CompId = c.Int(nullable: false, identity: true),
                        CompTypeName = c.String(),
                        GA = c.Int(nullable: false),
                        Price1 = c.Int(nullable: false),
                        Price2 = c.Int(nullable: false),
                        SWest = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CompId);
            
            CreateTable(
                "dbo.Inquiries",
                c => new
                    {
                        InquiryId = c.Int(nullable: false, identity: true),
                        Inventory = c.String(),
                        TotalTickets = c.Int(nullable: false),
                        GA = c.Int(nullable: false),
                        Price1 = c.Int(nullable: false),
                        Price2 = c.Int(nullable: false),
                        Disa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InquiryId);
            
            CreateTable(
                "dbo.PriceLevelDetails",
                c => new
                    {
                        PricLevelDetailId = c.Int(nullable: false, identity: true),
                        TicketTypeName = c.String(),
                        Qualifier1 = c.String(),
                        Qualifier2 = c.String(),
                        Qualifier3 = c.String(),
                        FaceValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalTickeets = c.Int(nullable: false),
                        TotalFaceValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NetCapacityPErcentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AgentAssistenPhone = c.Int(nullable: false),
                        Internet = c.Int(nullable: false),
                        PrimaryBoxOffice = c.Int(nullable: false),
                        SecondaryBoxOffice = c.Int(nullable: false),
                        TAP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PricLevelDetailId);
            
            CreateTable(
                "dbo.PriceLevelStats",
                c => new
                    {
                        PriceLevelStatId = c.Int(nullable: false, identity: true),
                        PriceLevel = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Sold = c.Int(nullable: false),
                        Comps = c.Int(nullable: false),
                        Opens = c.Int(nullable: false),
                        Holds = c.Int(nullable: false),
                        NetCapacity = c.Int(nullable: false),
                        SeatCapacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PriceLevelStatId);
            
            CreateTable(
                "dbo.PriceLevelUnsolds",
                c => new
                    {
                        PriceLevelUnsoldId = c.Int(nullable: false, identity: true),
                        Price = c.String(),
                        TicketType = c.String(),
                        Qualifier1 = c.String(),
                        Qualifier2 = c.String(),
                        Qualifier3 = c.String(),
                        TotalUnsold = c.Int(nullable: false),
                        NetCapacityPercent = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PriceLevelUnsoldId);
            
            CreateTable(
                "dbo.Prices",
                c => new
                    {
                        PriceId = c.Int(nullable: false, identity: true),
                        TicketType = c.String(),
                        Qualifier = c.String(),
                        GA = c.Int(nullable: false),
                        Price1 = c.Int(nullable: false),
                        Price2 = c.Int(nullable: false),
                        Price3 = c.Int(nullable: false),
                        Disa = c.Int(nullable: false),
                        SWEST = c.Int(nullable: false),
                        six = c.Int(nullable: false),
                        seven = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PriceId);
            
            CreateTable(
                "dbo.SalesChannelDetails",
                c => new
                    {
                        SalesChannelDetailId = c.Int(nullable: false, identity: true),
                        SalesChannelDetailName = c.String(),
                        TicketTypeName = c.String(),
                        Qualifier1 = c.String(),
                        Qualifier2 = c.String(),
                        Qualifier3 = c.String(),
                        TotalTickets = c.Int(nullable: false),
                        TotalFaceValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NetCapacityPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GA = c.Int(nullable: false),
                        Price1 = c.Int(nullable: false),
                        Price2 = c.Int(nullable: false),
                        Price3 = c.Int(nullable: false),
                        Disa = c.Int(nullable: false),
                        SWest = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SalesChannelDetailId);
            
            CreateTable(
                "dbo.Settlements",
                c => new
                    {
                        SettlementId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.SettlementId);
            
            CreateTable(
                "dbo.SummarySalesChannels",
                c => new
                    {
                        SummarySalesChannelId = c.Int(nullable: false, identity: true),
                        SummarySalesChannelName = c.String(),
                        TotalTickets = c.Int(nullable: false),
                        TotalFaceValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NetCapacityPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SummarySalesChannelId);
            
            CreateTable(
                "dbo.SummaryTicketTypes",
                c => new
                    {
                        SummaryTicketTypeId = c.Int(nullable: false, identity: true),
                        SummaryTicketName = c.String(),
                        TotalTickets = c.Int(nullable: false),
                        TotalFaceValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NetCapacityPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.SummaryTicketTypeId);
            
            CreateTable(
                "dbo.TicketTypeUnsolds",
                c => new
                    {
                        TicketTypeId = c.Int(nullable: false, identity: true),
                        TicketType = c.String(),
                        Qualifier1 = c.String(),
                        Qualifier2 = c.String(),
                        Qualifier3 = c.String(),
                        TotalUnsold = c.Int(nullable: false),
                        Potential = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GA = c.Int(nullable: false),
                        Price1 = c.Int(nullable: false),
                        Price2 = c.Int(nullable: false),
                        Price3 = c.Int(nullable: false),
                        Disa = c.Int(nullable: false),
                        SWEST = c.Int(nullable: false),
                        six = c.Int(nullable: false),
                        seven = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketTypeId);
            
            CreateTable(
                "dbo.W5Booking",
                c => new
                    {
                        W5Booking_RefId = c.Int(nullable: false, identity: true),
                        Res_Type = c.String(),
                        resource_name = c.String(),
                        EventName = c.String(),
                        Booked_Date = c.DateTime(nullable: false),
                        First_Payment_Received = c.DateTime(nullable: false),
                        Actual_Visit_Date = c.DateTime(nullable: false),
                        Booking_Visit_Date = c.DateTime(nullable: false),
                        Booking_ETA = c.Int(nullable: false),
                        BookedValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ActualValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Booked_Child = c.Int(nullable: false),
                        Actual_Child = c.Int(nullable: false),
                        Booked_Adult = c.Int(nullable: false),
                        Actual_Adult = c.Int(nullable: false),
                        Status = c.String(),
                        Booking_Category = c.String(),
                        Leader = c.String(),
                        title = c.String(),
                        forename = c.String(),
                        surname = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.W5Booking_RefId);
            
            CreateTable(
                "dbo.W5Membership",
                c => new
                    {
                        MembershipId = c.Int(nullable: false, identity: true),
                        Member_Type = c.String(),
                        DateJoined = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        Membership_status = c.String(),
                        Cancelled = c.String(),
                        Postitle = c.String(),
                        Company_Name = c.String(),
                        Country = c.String(),
                        PostCode = c.String(),
                        StatusDescription = c.String(),
                        PostalConsent = c.String(),
                        PhoneConsent = c.String(),
                        EmailConsent = c.String(),
                        SMSConsent = c.String(),
                    })
                .PrimaryKey(t => t.MembershipId);
            
            CreateTable(
                "dbo.W5Sale",
                c => new
                    {
                        W5SaleId = c.Int(nullable: false, identity: true),
                        Branch = c.String(),
                        Sale_ref = c.Int(nullable: false),
                        SessionNo = c.String(),
                        TillID = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Month = c.String(),
                        Day = c.String(),
                        Week = c.String(),
                        Hour = c.Int(nullable: false),
                        Slot = c.String(),
                        Tran_Date = c.DateTime(nullable: false),
                        PLU = c.Int(nullable: false),
                        privateDesc = c.String(),
                        Department = c.String(),
                        Catagory = c.String(),
                        SubCatagory = c.String(),
                        Supplier = c.String(),
                        cost_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Qty_Sold = c.Int(nullable: false),
                        price_paid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        vatAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Gross_line = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Gross_price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Net_line = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vat_description = c.String(),
                        DiscountType = c.String(),
                        VoucherName = c.String(),
                        SystemDiscount_Name = c.String(),
                        Discount_value = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Selling_Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Payment_Method = c.String(),
                        nominal = c.Int(nullable: false),
                        Adults = c.Int(nullable: false),
                        Children = c.Int(nullable: false),
                        Voucher_reference = c.String(),
                    })
                .PrimaryKey(t => t.W5SaleId);
            
            CreateTable(
                "dbo.W5SalesSummary",
                c => new
                    {
                        W5salesSummaryId = c.Int(nullable: false, identity: true),
                        Code = c.Int(nullable: false),
                        Description = c.String(),
                        Quantity = c.Int(nullable: false),
                        VAT = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Gross = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Profit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Profit_Percent = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.W5salesSummaryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.W5SalesSummary");
            DropTable("dbo.W5Sale");
            DropTable("dbo.W5Membership");
            DropTable("dbo.W5Booking");
            DropTable("dbo.TicketTypeUnsolds");
            DropTable("dbo.SummaryTicketTypes");
            DropTable("dbo.SummarySalesChannels");
            DropTable("dbo.Settlements");
            DropTable("dbo.SalesChannelDetails");
            DropTable("dbo.Prices");
            DropTable("dbo.PriceLevelUnsolds");
            DropTable("dbo.PriceLevelStats");
            DropTable("dbo.PriceLevelDetails");
            DropTable("dbo.Inquiries");
            DropTable("dbo.CompTypes");
            DropTable("dbo.ArenaEventSummaryPriceLevels");
            DropTable("dbo.ArenaEventCapacities");
            DropTable("dbo.ArenaEventAudits");
        }
    }
}
