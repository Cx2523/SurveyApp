using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SurveyAppClassLibrary.Models;
using SurveyAppClassLibrary.Data;

namespace SurveyApp.Controllers
{
    public class UserController : Controller
    {
        [HttpPost]
        public ActionResult Index(User requestedUser)
        {
            UserRepository Repo = new UserRepository();
            User user = Repo.GetUserByUsername(requestedUser.Username);

            return View(user);
        }

        public ActionResult CreateNewClient(Client newClient)
        {
            UserRepository Repo = new UserRepository();
            Repo.AddClient(newClient);
            return View();
        }
    }
}