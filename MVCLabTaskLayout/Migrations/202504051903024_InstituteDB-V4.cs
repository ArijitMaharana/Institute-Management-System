namespace MVCLabTaskLayout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InstituteDBV4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "EmailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Mobile", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Mobile", c => c.String());
            AlterColumn("dbo.Students", "EmailAddress", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
        }
    }
}
