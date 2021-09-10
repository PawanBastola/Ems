using Ems.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ems.Controllers
{
    public class LoginController : Controller
    {

        DataContext dal = new DataContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginCheck(String username, String password)
        {
            var user_List = dal.userlogins.Where(x => x.username.Equals(username)).Where(y => y.password.Equals(password)).ToList();

            

            if (user_List.Count() == 1 && user_List[0].password.Equals(password) && user_List[0].role.Equals("Teacher"))
            {
                //Teacher role
                //setting session using HttpContext
                HttpContext.Session.SetString("username", user_List[0].username);
                HttpContext.Session.SetString("logged", "true");


                return RedirectToAction("Index", "Question");
            }

            else if (user_List.Count() == 1 && user_List[0].password.Equals(password) && user_List[0].role.Equals("Student"))
            {
                HttpContext.Session.SetString("username", user_List[0].username);
                HttpContext.Session.SetString("logged", "true");

                return RedirectToAction("SelectSubject", "Question");
            }
            
            
            else
            {
                TempData["error"] = "invalid credentials";
                return RedirectToAction("Index", "Login");
            }

        }

        //logout action
        public IActionResult Logout()
        {

            HttpContext.Session.SetString("logged", "");
            HttpContext.Session.SetString("username", "");

            return RedirectToAction("Index", "Login");
        }
       

    }
}
