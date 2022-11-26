namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTable4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.W5Sale", "Staff", c => c.String());
            AddColumn("dbo.W5Sale", "Weekstart", c => c.DateTime());
            AddColumn("dbo.W5Sale", "TranTime", c => c.String());
            AddColumn("dbo.W5Sale", "Visit_Date", c => c.DateTime());
            AddColumn("dbo.W5Sale", "Gross_line_Total", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.W5Sale", "Vat_line", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.W5Sale", "VatRate", c => c.Int());
            AddColumn("dbo.W5Sale", "PersonId", c => c.Int());
            AlterColumn("dbo.W5Sale", "Sale_ref", c => c.Int());
            AlterColumn("dbo.W5Sale", "TillID", c => c.Int());
            AlterColumn("dbo.W5Sale", "Year", c => c.Int());
            AlterColumn("dbo.W5Sale", "Week", c => c.Int(nullable: false));
            AlterColumn("dbo.W5Sale", "Hour", c => c.Int());
            AlterColumn("dbo.W5Sale", "Tran_Date", c => c.DateTime());
            AlterColumn("dbo.W5Sale", "PLU", c => c.Int());
            AlterColumn("dbo.W5Sale", "cost_price", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.W5Sale", "Qty_Sold", c => c.Int());
            AlterColumn("dbo.W5Sale", "price_paid", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.W5Sale", "vatAmt", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.W5Sale", "Net_line", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.W5Sale", "Discount_value", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.W5Sale", "Selling_Price", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.W5Sale", "nominal", c => c.Int());
            AlterColumn("dbo.W5Sale", "Adults", c => c.Int());
            AlterColumn("dbo.W5Sale", "Children", c => c.Int());
            DropColumn("dbo.W5Sale", "Gross_line");
            DropColumn("dbo.W5Sale", "Gross_price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.W5Sale", "Gross_price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.W5Sale", "Gross_line", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.W5Sale", "Children", c => c.Int(nullable: false));
            AlterColumn("dbo.W5Sale", "Adults", c => c.Int(nullable: false));
            AlterColumn("dbo.W5Sale", "nominal", c => c.Int(nullable: false));
            AlterColumn("dbo.W5Sale", "Selling_Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.W5Sale", "Discount_value", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.W5Sale", "Net_line", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.W5Sale", "vatAmt", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.W5Sale", "price_paid", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.W5Sale", "Qty_Sold", c => c.Int(nullable: false));
            AlterColumn("dbo.W5Sale", "cost_price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.W5Sale", "PLU", c => c.Int(nullable: false));
            AlterColumn("dbo.W5Sale", "Tran_Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.W5Sale", "Hour", c => c.Int(nullable: false));
            AlterColumn("dbo.W5Sale", "Week", c => c.String());
            AlterColumn("dbo.W5Sale", "Year", c => c.Int(nullable: false));
            AlterColumn("dbo.W5Sale", "TillID", c => c.Int(nullable: false));
            AlterColumn("dbo.W5Sale", "Sale_ref", c => c.Int(nullable: false));
            DropColumn("dbo.W5Sale", "PersonId");
            DropColumn("dbo.W5Sale", "VatRate");
            DropColumn("dbo.W5Sale", "Vat_line");
            DropColumn("dbo.W5Sale", "Gross_line_Total");
            DropColumn("dbo.W5Sale", "Visit_Date");
            DropColumn("dbo.W5Sale", "TranTime");
            DropColumn("dbo.W5Sale", "Weekstart");
            DropColumn("dbo.W5Sale", "Staff");
        }
    }
}
