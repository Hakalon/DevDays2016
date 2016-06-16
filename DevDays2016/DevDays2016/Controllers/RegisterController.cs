using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevDays2016.Models;

namespace DevDays2016.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Send(string name, string tel, string email,string nickName, string prof, string interestIn, string wantToMeet)
        {
            PostContext ptemp = new PostContext();
            User temp = new User();
            temp.Name = name;
            temp.NickName = nickName;
            temp.Tel = tel;
            temp.Email = email;
            temp.Profession = prof;
            temp.InterestIn = interestIn;
            temp.WantToMeet = wantToMeet;
            ptemp.Users.Add(temp);
            ptemp.SaveChanges();

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