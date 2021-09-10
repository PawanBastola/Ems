using Ems.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ems.Controllers
{
    public class MarksController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Index(String[] answer, String subject)
        {
            List<Question> studentQuestion = dal.questions.Where(x => x.subject.Equals(subject)).ToList();
            int count = studentQuestion.Where(x => answer.All(y => y.Equals(x.answer))).ToList().Count();
            ViewBag.Marks = "you Obtained " + count + "in a test";
            
            return View();
        }
    }
}
