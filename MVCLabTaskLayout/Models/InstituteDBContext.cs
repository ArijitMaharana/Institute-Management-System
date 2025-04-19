using MVCLabTaskLayout.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCLabTaskLayout.Models
{
    public class InstituteDBContext:DbContext
    {

        public InstituteDBContext():base("ConStr")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<InstituteDBContext, Configuration>());
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<RegisterAdmin> RegisterAdmins { get; set; }

        public DbSet<Faculty> Faculties { get; set; }
    }
}