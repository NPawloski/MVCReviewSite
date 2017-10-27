namespace MVCReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReviewer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Reviewer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Reviewer");
        }
    }
}
