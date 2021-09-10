using Ems.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ems.Controllers
{
    public class QuestionController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddQuestion(Question myquesion, String[] mcqoption)
        {
            myquesion.answer = mcqoption[0];
            dal.questions.Add(myquesion);
            dal.SaveChanges();

            int qid = dal.questions.Where(x => x.questions.Equals(myquesion.questions)).Where(y => y.subject.Equals(myquesion.subject)).First().qid;

            foreach (var item in mcqoption)
            {
                dal.optionss.Add(new Options() { mcqoption = item, qid = qid });
            }
            dal.SaveChanges();
            return RedirectToAction("Index", "Question");

        }

        public IActionResult SelectSubject()
        {
            return View();
        }

        public IActionResult Exam(String subject)
        {
            ViewBag.MyQuestion = dal.questions.Where(x => x.subject.Equals(subject)).ToList();
            
            return View();
        }

        //counting the marks of the student
       /* public IActionResult CountMarks()
        {
            //List<Doctor_Details> date_filters = available_doctors.Where(x => udatelist.All(y => y.did != x.d_id)).ToList<Doctor_Details>();

            //int count = dal.questions.Where(x=>x.subject.Equals(subject)).Where(y=>answer.All(y=>y.Equals(x.answer))).ToList().Count();
            
        }
*/

        public IActionResult Submit(IFormCollection iformCollection)
        {
            int count = 0;
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
            //counting the objects
            /*var data = examquestionlist.Where(x => x.answer.Equals(givenanswer)).ToList();*/


           /* if (givenanswer[i]==examquestionlist.Where(x=>x.answer.Equals(givenanswer[i])))
            {

            }*/
           

            /*foreach (var questionId in questionIds)
            {
                int totalscore = dal.questions.Where()
            }*/

            return RedirectToAction("Index","Marks");
        }

    }
}

