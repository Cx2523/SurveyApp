using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SurveyAppClassLibrary.Models;
using SurveyAppClassLibrary.Data;

namespace SurveyApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public void UserForm(FormCollection values)
        {
            Repository Repo = new Repository();
            Repo.AddUser(values["Username"], values["Email"]);
            
        }
        public ActionResult LoginForm()
        {
            Repository Repo = new Repository();
            User user = Repo.GetUserByUsername(this.Request.QueryString["Username"]);

            return RedirectToAction("Index", "User", new { username = user.Username });
        }
    }
}