using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevDays2016.Models;
using System.Data.Entity;

namespace DevDays2016.Controllers
{
    public class QuestionController : Controller
    {
        // GET: Question
        public ActionResult Index()
        {
            return View("QA");
        }

        public ActionResult Send(string userName, string content)
        {
            PostContext dbContext = new PostContext();

            Question Qtemp = new Question();
            Qtemp.Content = content;

            //if(!String.IsNullOrEmpty(userName))
                

            return RedirectToAction("Index");
        }
    }
}