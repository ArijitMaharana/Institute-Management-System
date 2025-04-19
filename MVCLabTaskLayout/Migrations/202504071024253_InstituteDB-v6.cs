namespace MVCLabTaskLayout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InstituteDBv6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Gender", c => c.String(nullable: false));
            AddColumn("dbo.Students", "DateOfRegistration", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "FeeStatus", c => c.String());
            AddColumn("dbo.Students", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Address");
            DropColumn("dbo.Students", "FeeStatus");
            DropColumn("dbo.Students", "DateOfRegistration");
            DropColumn("dbo.Students", "Gender");
        }
    }
}
