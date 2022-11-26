namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatetables3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.W5Membership", "Tel2", c => c.String());
            DropColumn("dbo.W5Membership", "Tell2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.W5Membership", "Tell2", c => c.String());
            DropColumn("dbo.W5Membership", "Tel2");
        }
    }
}
