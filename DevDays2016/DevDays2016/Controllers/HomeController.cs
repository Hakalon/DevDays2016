using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevDays2016.Models;

namespace DevDays2016.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Agenda()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QA()
        {
            PostContext dbContext = new PostContext();
            List<Question> value;
            value = dbContext.Questions.ToList();

            return View("QA", value);
        
        }
        public ActionResult Answer()
        {
            return View();
        }
        public ActionResult Send()
        {
            return View("Thanks");
        }
    }
}