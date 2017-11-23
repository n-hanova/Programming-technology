namespace OlympMotors.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "NameUser", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "NameUser");
        }
    }
}
