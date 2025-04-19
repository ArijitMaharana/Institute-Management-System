using MVCLabTaskLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLabTaskLayout.Controllers
{
    public class CoursesController : Controller
    {
        InstituteDBContext  dc = new InstituteDBContext();
        public ViewResult CourseList()
        {
            return View(dc.Courses);
        }
        public ViewResult DisplayCourses()
        {
            return View(dc.Courses);
        }
        public ViewResult Displaycourse(int id)
        {
            
            return View(dc.Courses.Find(id));
        }
        [HttpGet]
        public ViewResult AddCourse()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult AddCourse(Course course)
        {
            dc.Courses.Add(course);
            dc.SaveChanges();
            return RedirectToAction("DisplayCourses");
        }

        public ViewResult EditCourse(int id)
        {
            return View(dc.Students.Find(id));
        }
        public RedirectToRouteResult UpdateCourse(Course course)
        {
            dc.Entry(course).State = System.Data.Entity.EntityState.Modified;
            dc.SaveChanges();
            return RedirectToAction("DisplayCourses");
        }
        public RedirectToRouteResult DeleteCourse(int id)
        {
            var course = dc.Students.Find(id);
            dc.Students.Remove(course);
            dc.SaveChanges();
            return RedirectToAction("DisplayCourses");
        }

    }
}