using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SurveyAppClassLibrary.Models;
using SurveyAppClassLibrary.Data;
using SurveyAppClassLibrary.Data.Repositories;

namespace SurveyApp.Controllers
{
    public class HomeController : Controller
    {
        private Context _context = null;

        public HomeController()
        {
            _context = new Context();
        }

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
            //UserRepository Repo = new UserRepository();
            //Repo.AddUser(values["Username"], values["Email"]);
            
        }
        public ActionResult LoginForm()
        {
            
            UserRepository Repo = new UserRepository(_context);
            User user = Repo.GetUserByUsernameAndEmail(this.Request.QueryString["Username"], this.Request.QueryString["Email"]);

            return RedirectToAction("Index", "User", user);
        }
    }
}