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
            return RedirectToAction("QA", "Home");
            //return View("QA", "Home", value);
        }

        public ActionResult Send(string name, string content)
        {
            PostContext dbContext = new PostContext();

            Question Qtemp = new Question();

            Qtemp.Name = name;
            Qtemp.Content = content;

            dbContext.Questions.Add(Qtemp);
            dbContext.SaveChanges();

            //ViewBag.Name = userName;
            
            return RedirectToAction("Index");
        }
    }
}