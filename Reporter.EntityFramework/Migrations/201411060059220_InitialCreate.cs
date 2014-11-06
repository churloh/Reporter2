namespace Reporter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SitReps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReporterId = c.Int(),
                        Description = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ReporterId)
                .Index(t => t.ReporterId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SitReps", "ReporterId", "dbo.Users");
            DropIndex("dbo.SitReps", new[] { "ReporterId" });
            DropTable("dbo.Users");
            DropTable("dbo.SitReps");
        }
    }
}
