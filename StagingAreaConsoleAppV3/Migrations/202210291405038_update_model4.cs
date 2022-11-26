namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_model4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.W5Membership", "Title", c => c.String());
            AddColumn("dbo.W5Membership", "Forename", c => c.String());
            AddColumn("dbo.W5Membership", "Surname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.W5Membership", "Surname");
            DropColumn("dbo.W5Membership", "Forename");
            DropColumn("dbo.W5Membership", "Title");
        }
    }
}
