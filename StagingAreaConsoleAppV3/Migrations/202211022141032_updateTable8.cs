namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTable8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.W5SalesSummary", "VisitorQuantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.W5SalesSummary", "VisitorQuantity");
        }
    }
}
