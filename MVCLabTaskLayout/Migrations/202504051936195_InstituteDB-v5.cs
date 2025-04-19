namespace MVCLabTaskLayout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InstituteDBv5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RegisterAdmins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        Name = c.String(),
                        Email = c.String(),
                        Mobile = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RegisterAdmins");
        }
    }
}
