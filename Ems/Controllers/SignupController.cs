using Ems.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ems.Controllers
{
    public class SignupController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddTeacher(Userlogin login)
        {
            login.role = "Teacher";
            dal.userlogins.Add(login);
            dal.SaveChanges();
            return RedirectToAction("Index", "Signup");
        }
        public IActionResult AddStudent(Userlogin login)
        {
            login.role = "Student";
            dal.userlogins.Add(login);
            dal.SaveChanges();
            return RedirectToAction("Index", "Signup");
        }
    }
}
