using MVCLabTaskLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLabTaskLayout.Filters;
using System.Data.Entity;

namespace MVCLabTaskLayout.Controllers
{

    public class AdminController : Controller
    {

        InstituteDBContext dc = new InstituteDBContext();


        #region Add/Edit/Update/Delete Student Records

        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult DisplayStudents()
        {
            dc.Configuration.LazyLoadingEnabled = false;
            var courses = dc.Courses.Select(c => c.Name); // Get all available courses

            ViewBag.Courses = courses;
            return View(dc.Students.Include(s => s.Course));
        }
        public ActionResult DisplayStudent(int id)
        {
            dc.Configuration.LazyLoadingEnabled = false;
            return View(dc.Students.Include(s => s.Course).Where(s => s.StudentId == id).Single());
        }
        public ActionResult EditStudent(int id)
        {
            var student = dc.Students.Find(id);
            ViewBag.CourseId = new SelectList(dc.Courses, "CourseId", "Name", student.CourseId);
            return View(student);
        }
        public RedirectToRouteResult UpdateStudent(Student student)
        {
            dc.Entry(student).State = EntityState.Modified;
            dc.SaveChanges();
            return RedirectToAction("DisplayStudents");
        }
        public ActionResult DeleteStudent(int id)
        {
            dc.Students.Remove(dc.Students.Find(id));
            dc.SaveChanges();
            return RedirectToAction("DisplayStudents");
        }


        #endregion


        #region Edit/Update/Delete Admin Records


        public ActionResult DisplayAdmins()
        {
            return View(dc.RegisterAdmins.Where(a => a.Status == true));
        }

        public ActionResult DisplayAdmin(string id)
        {
            return View(dc.RegisterAdmins.Find(id));
        }
        public ActionResult EditAdmin(string id)
        {
            return View(dc.RegisterAdmins.Find(id));
        }

        public ActionResult UpdateAdmin(RegisterAdmin admin)
        {
            dc.Entry(admin).State = EntityState.Modified;
            dc.SaveChanges();
            return RedirectToAction("DisplayAdmins");

        }
        public ActionResult DeleteAdmin(string id)
        {
            var admin = dc.RegisterAdmins.Find(id);
            dc.RegisterAdmins.Remove(admin);
            dc.SaveChanges();
            return RedirectToAction("DisplayAdmins");
        }



        #endregion


        #region Add/Edit/Update/Delete Courses 


        public ViewResult DisplayCourses()
        {
            return View(dc.Courses);
        }

        public ViewResult DisplayCourse(int id)
        {
            return View(dc.Courses.Find(id));
        }
        [HttpGet]
        public ViewResult AddCourse()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                dc.Courses.Add(course);
                dc.SaveChanges();
                return RedirectToAction("DisplayCourses");
            }
            else
            {
                return View(course);
            }
        }
        public ViewResult EditCourse(int id)
        {
            return View((dc.Courses.Find(id)));
        }
        public ActionResult UpdateCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                dc.Entry(course).State = EntityState.Modified;
                dc.SaveChanges();
                return RedirectToAction("DisplayCourses");
            }
            else
            {
                return View(course);
            }

        }
        public RedirectToRouteResult DeleteCourse(int id)
        {
            var course = dc.Courses.Find(id);
            dc.Courses.Remove(course);
            dc.SaveChanges();
            return RedirectToAction("DisplayCourses");
        }

        #endregion




        #region Add/Edit/Update/Delete Faculties 


        public ViewResult DisplayFaculties()
        {
            return View(dc.Faculties);
        }

        public ViewResult DisplayFaculty(int id)
        {
            return View(dc.Faculties.Find(id));
        }
        [HttpGet]
        public ViewResult AddFaculty()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddFaculty(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                dc.Faculties.Add(faculty);
                dc.SaveChanges();
                return RedirectToAction("DisplayFaculties");
            }
            else
            {
                return View(faculty);
            }
        }
        public ViewResult EditFaculty(int id)
        {
            return View((dc.Faculties.Find(id)));
        }
        public ActionResult UpdateFaculty(Faculty faculty)
        {
            dc.Entry(faculty).State = EntityState.Modified;
            dc.SaveChanges();
            return RedirectToAction("DisplayFaculties");
        }
        public RedirectToRouteResult DeleteFaculty(int id)
        {
            var faculty = dc.Faculties.Find(id);
            dc.Faculties.Remove(faculty);
            dc.SaveChanges();
            return RedirectToAction("DisplayFaculties");
        }

        #endregion





    }
}