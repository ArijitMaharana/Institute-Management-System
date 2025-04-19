using MVCLabTaskLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLabTaskLayout.Controllers
{
    public class AdmissionsController : Controller
    {
        InstituteDBContext dc = new InstituteDBContext();
        [HttpGet]
        public ViewResult Apply()
        {
            ViewBag.CourseId = new SelectList(dc.Courses, "CourseId", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Apply(Student s1)
        {
            if(ModelState.IsValid)
            {
                dc.Students.Add(s1);
                dc.SaveChanges();
                TempData["SuccessMessage"] = "Registration successful! Our team will get back to you soon.";
                return RedirectToAction("Apply");
            }
            ViewBag.CourseId = new SelectList(dc.Courses, "CourseId", "Name");
            return View();
        }
    }
}