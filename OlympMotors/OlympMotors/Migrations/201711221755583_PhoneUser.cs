namespace OlympMotors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PhoneUser", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "PhoneUser");
        }
    }
}
