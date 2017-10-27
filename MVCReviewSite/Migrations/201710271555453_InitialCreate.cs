namespace MVCReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        PublishedDate = c.DateTime(nullable: false),
                        Cetagory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.Cetagory, cascadeDelete: true)
                .Index(t => t.Cetagory);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Cetagory", "dbo.Categories");
            DropIndex("dbo.Reviews", new[] { "Cetagory" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Categories");
        }
    }
}
