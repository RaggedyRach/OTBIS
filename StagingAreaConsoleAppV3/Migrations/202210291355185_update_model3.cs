namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_model3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.W5Membership", "Membership_scheme", c => c.String());
            AddColumn("dbo.W5Membership", "Membership_number", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.W5Membership", "Membership_number");
            DropColumn("dbo.W5Membership", "Membership_scheme");
        }
    }
}
