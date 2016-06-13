namespace DevDays2016.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDevDays2016 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Response",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Tel = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
            DropTable("dbo.Response");
            DropTable("dbo.Question");
        }
    }
}
