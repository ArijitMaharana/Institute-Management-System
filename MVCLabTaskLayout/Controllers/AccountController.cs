using MVCLabTaskLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace MVCLabTaskLayout.Controllers
{
    public class AccountController : Controller
    {
        InstituteDBContext dc = new InstituteDBContext();

        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var Admin = from admin in dc.RegisterAdmins where admin.UserId == model.Userid && admin.Password == model.Password  select admin;
                if(Admin.Count() == 0)
                {
                    ModelState.AddModelError("", "Invalid UserId Or Password");
                    return View(model);
                }
                else
                {
                    Session["UserKey"] = Guid.NewGuid();
                    Session["IsAdmin"] = true;
                    Session["AdminName"] = model.Userid;
                    return RedirectToAction("Dashboard", "Admin");
                }
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public ViewResult RegisterAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterAdmin(RegisterAdminViewModel admin)
        {
            if(ModelState.IsValid)
            {
                RegisterAdmin admin1 = new RegisterAdmin
                {
                    UserId = admin.UserId,
                    Password = admin.Password, 
                    Name = admin.Name,
                    Email = admin.Email,
                    Mobile = admin.Mobile,
                    Status = true
                };
                dc.RegisterAdmins.Add(admin1);
                dc.SaveChanges();
                ViewBag.Message = "Registration successful! You can now login to access the admin site.";
                ModelState.Clear();
                return View();
            }
            else 
                return View(admin);
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}