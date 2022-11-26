namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTable7 : DbMigration
    {

        public override void Up()
        {
            CreateTable(
              "dbo.W5SalesSummary",
              c => new
              {
                  W5salesSummaryId = c.Int(nullable: false, identity: true),
                  Code = c.Int(nullable: false),
                  Description = c.String(),
                  Quantity = c.Int(nullable: false),
                  NetValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                  VAT = c.Decimal(nullable: false, precision: 18, scale: 2),
                  Gross = c.Decimal(nullable: false, precision: 18, scale: 2),
                  Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                  Profit = c.Decimal(nullable: false, precision: 18, scale: 2),
                  Profit_Percent = c.Decimal(nullable: false, precision: 18, scale: 2),
              })
              .PrimaryKey(t => t.W5salesSummaryId);

            AlterColumn("dbo.W5SalesSummary", "Code", c => c.Int());
            AlterColumn("dbo.W5SalesSummary", "Quantity", c => c.Int());
            AlterColumn("dbo.W5SalesSummary", "NetValue", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.W5SalesSummary", "VAT", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.W5SalesSummary", "Gross", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.W5SalesSummary", "Cost", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.W5SalesSummary", "Profit", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.W5SalesSummary", "Profit_Percent", c => c.Decimal(precision: 18, scale: 2));

        }
        
        public override void Down()
        {
            AlterColumn("dbo.W5SalesSummary", "Profit_Percent", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.W5SalesSummary", "Profit", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.W5SalesSummary", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.W5SalesSummary", "Gross", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.W5SalesSummary", "VAT", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.W5SalesSummary", "NetValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.W5SalesSummary", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.W5SalesSummary", "Code", c => c.Int(nullable: false));
        }
    }
}
