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

            /* List<Question> studentQuestion = dal.questions.Where(x => x.subject.Equals(subject)).ToList();
             int count = studentQuestion.Where(x => answer.All(y => y.Equals(x.answer))).ToList().Count();
             ViewBag.Marks = "you Obtained " + count + "in a test";*/
            //new
            string[] questionIds = iformCollection["questionId"];
            string[] givenanswer = new string[questionIds.Length];
            //String[] variable_name = new String[provide_size_here];

            /*List<ViewModelAppointment> viewmodellist = appointmentlist.Select(appointmentx => new ViewModelAppointment()
                 {
                     aid=appointmentx.aid,
                     doc_id= appointmentx.doc_id,
                     uid = appointmentx.uid,
                     adate = appointmentx.adate,
                     patient_name = dal.Patients.Where(x=>x.p_id==appointmentx.uid).First().p_fullname
                 }).ToList();*/
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




            //counting the objects
            /*var data = examquestionlist.Where(x => x.answer.Equals(givenanswer)).ToList();*/


            /* if (givenanswer[i]==examquestionlist.Where(x=>x.answer.Equals(givenanswer[i])))
             {

             }*/


            /*foreach (var questionId in questionIds)
            {
                int totalscore = dal.questions.Where()
            }*/

            return View();

        }
        //new
    }

}
