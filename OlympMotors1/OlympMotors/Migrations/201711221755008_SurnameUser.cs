namespace OlympMotors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SurnameUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "SurnameUser", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "SurnameUser");
        }
    }
}
