namespace TravelReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsername : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Username", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Username");
        }
    }
}
