namespace DevDays2016.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Questionnaire : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Questionnaire",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Place = c.Int(nullable: false),
                        Staff = c.Int(nullable: false),
                        Activity = c.Int(nullable: false),
                        Information = c.String(),
                        Other = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Response");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Response",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Questionnaire");
        }
    }
}
