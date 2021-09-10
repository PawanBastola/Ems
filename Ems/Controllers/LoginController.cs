using Ems.Models;
using Microsoft.AspNetCore.Mvc;
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
                //admin role
                //setting session using HttpContext
                return RedirectToAction("Index", "Question");
            }

            else if (user_List.Count() == 1 && user_List[0].password.Equals(password) && user_List[0].role.Equals("Student"))
            {
                return RedirectToAction("SelectSubject", "Question");
            }
            
            
            else
            {
                TempData["error"] = "invalid credentials";
                return RedirectToAction("Index", "Login");
            }

        }

        //yo action kai call vako xaina.
       

    }
}
