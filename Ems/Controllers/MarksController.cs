using Ems.Models;
using Microsoft.AspNetCore.Http;
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
        private object iformCollection;

        public IActionResult Index(IFormCollection iformCollection)
        {
            if (HttpContext.Session.GetString("logged") == "true")
            {

            //new
            string[] questionIds = iformCollection["questionId"];
            string[] givenanswer = new string[questionIds.Length];
            //String[] variable_name = new String[provide_size_here];


            List<Question> examquestionlist = new List<Question>();



            int i = 0;
            foreach (var qid in questionIds)
            {
                Question iterate = dal.questions.Where(x => x.qid.Equals(int.Parse(qid))).Single();
                examquestionlist.Add(iterate);
                //answer in array
                givenanswer[i] = iformCollection["option_" + qid];
                i++;
            }

            int cc = 0;
            for (int a = 0; a < givenanswer.Length; a++)
            {
                if (givenanswer[a].Equals(examquestionlist[a].answer))
                {
                    cc++;
                    ViewBag.Marks = cc;
                }
            }

            //ViewBag.givenans = givenanswer.Length;
            ViewBag.totalquestion = examquestionlist.Count;
            //ViewBag.Marks = 5;



            return View();
            }
            else
            {
                return RedirectToAction("Logout","Login");
            }

        }
       
    }

}
