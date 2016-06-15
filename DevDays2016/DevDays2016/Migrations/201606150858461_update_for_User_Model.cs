namespace DevDays2016.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update_for_User_Model : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "NickName", c => c.String());
            AddColumn("dbo.User", "Profession", c => c.String());
            AddColumn("dbo.User", "InterestIn", c => c.String());
            AddColumn("dbo.User", "WantToMeet", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "WantToMeet");
            DropColumn("dbo.User", "InterestIn");
            DropColumn("dbo.User", "Profession");
            DropColumn("dbo.User", "NickName");
        }
    }
}
