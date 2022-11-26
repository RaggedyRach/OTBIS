namespace StagingAreaConsoleAppV3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newtable3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SubCategories", "CategoryId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SubCategories", "CategoryId", c => c.Int(nullable: false));
        }
    }
}
