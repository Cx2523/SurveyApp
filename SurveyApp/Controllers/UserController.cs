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
    public class UserController : Controller
    {
        private Context _context = null;
        public UserController()
        {
            _context = new Context();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            return View(user);
        }

        //public ActionResult CreateNewClient(Client newClient)
        //{
        //    UserRepository Repo = new UserRepository();
        //    Repo.AddClient(newClient);
        //    return View();
        //}
    }
}