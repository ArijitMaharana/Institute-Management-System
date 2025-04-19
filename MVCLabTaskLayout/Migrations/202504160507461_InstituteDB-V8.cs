namespace MVCLabTaskLayout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InstituteDBV8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Faculties",
                c => new
                    {
                        FacultyId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false),
                        Phone = c.String(),
                        Experience = c.Int(nullable: false),
                        SubjectsTaught = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => t.FacultyId);
            
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Courses", "Duration", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "Duration", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
            DropTable("dbo.Faculties");
        }
    }
}
