namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTable6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.W5SalesSummary", "NetValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.W5SalesSummary", "NetValue");
        }
    }
}
