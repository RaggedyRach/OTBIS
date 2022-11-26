namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CarParks", "StayTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CarParks", "StayTime", c => c.String());
        }
    }
}
