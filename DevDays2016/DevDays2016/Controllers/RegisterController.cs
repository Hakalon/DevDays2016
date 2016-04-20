using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DevDays2016.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Send()
        {
            return View("Signin");
        }
        public ActionResult SendSignin()
        {
            return View("Picture");
        }

        public ActionResult Signin()
        {
            return View("Signin");
        }
    }
}