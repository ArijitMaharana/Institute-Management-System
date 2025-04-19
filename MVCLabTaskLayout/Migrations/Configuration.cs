namespace MVCLabTaskLayout.Migrations
{
    using MVCLabTaskLayout.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCLabTaskLayout.Models.InstituteDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCLabTaskLayout.Models.InstituteDBContext dc)
        {

            dc.Courses.AddOrUpdate(
                         c => c.Name,  // Match by Name instead of CourseId
                        new Course { Name = ".Net Full Stack", Fees = 30000, Duration = "6 Months" },
                        new Course { Name = "Java Full Stack", Fees = 32000, Duration = "6 Months" },
                        new Course { Name = "Python Full Stack", Fees = 20000, Duration = "6 Months" },
                        new Course { Name = "AWS & Devops", Fees = 15000, Duration = "4 Months" },
                        new Course { Name = "Data Science", Fees = 40000, Duration = "8 Months" },
                        new Course { Name = "React", Fees = 8000, Duration = "2 Months" },
                        new Course { Name = "Angular", Fees = 8000, Duration = "2 Months" },
                        new Course { Name = "Testing", Fees = 6000, Duration = "3 Months" },
                        new Course { Name = "Power BI", Fees = 8000, Duration = "3 Months" },
                        new Course { Name = "RPA Developer", Fees = 20000, Duration = "6 Months" }

                      );
            dc.SaveChanges();
        }
    }
}
