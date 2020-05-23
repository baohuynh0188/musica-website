namespace MusicaWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserProfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.AspNetUsers", "Date", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Month", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Year", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Gender");
            DropColumn("dbo.AspNetUsers", "Year");
            DropColumn("dbo.AspNetUsers", "Month");
            DropColumn("dbo.AspNetUsers", "Date");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
