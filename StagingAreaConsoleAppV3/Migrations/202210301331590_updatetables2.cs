namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetables2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.W5Membership", "HouseNo", c => c.String());
            AddColumn("dbo.W5Membership", "Add1", c => c.String());
            AddColumn("dbo.W5Membership", "Add2", c => c.String());
            AddColumn("dbo.W5Membership", "Add3", c => c.String());
            AddColumn("dbo.W5Membership", "City", c => c.String());
            AddColumn("dbo.W5Membership", "County", c => c.String());
            AddColumn("dbo.W5Membership", "Tel1", c => c.String());
            AddColumn("dbo.W5Membership", "Tell2", c => c.String());
            AddColumn("dbo.W5Membership", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.W5Membership", "Email");
            DropColumn("dbo.W5Membership", "Tell2");
            DropColumn("dbo.W5Membership", "Tel1");
            DropColumn("dbo.W5Membership", "County");
            DropColumn("dbo.W5Membership", "City");
            DropColumn("dbo.W5Membership", "Add3");
            DropColumn("dbo.W5Membership", "Add2");
            DropColumn("dbo.W5Membership", "Add1");
            DropColumn("dbo.W5Membership", "HouseNo");
        }
    }
}
