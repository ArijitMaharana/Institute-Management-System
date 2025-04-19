namespace MVCLabTaskLayout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InstituteDBV2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "CourseId", "dbo.Courses");
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Courses", "CourseId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Courses", "CourseId");
            AddForeignKey("dbo.Students", "CourseId", "dbo.Courses", "CourseId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CourseId", "dbo.Courses");
            DropPrimaryKey("dbo.Courses");
            AlterColumn("dbo.Courses", "CourseId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Courses", "CourseId");
            AddForeignKey("dbo.Students", "CourseId", "dbo.Courses", "CourseId", cascadeDelete: true);
        }
    }
}
