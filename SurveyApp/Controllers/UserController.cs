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

        private UnitOfWork unitOfWork = new UnitOfWork();

        public ActionResult Index()
        {
            User user = unitOfWork.UserRepository.GetUserByUsernameAndEmail(this.Request.QueryString["Username"], this.Request.QueryString["Email"]);

            return View(user);
        }

        public void GetClients()
        {
            ViewBag.Clients = unitOfWork.ClientRepository.GetClients();
        }

        public void InsertClient(Client newClient)
        {
            
            unitOfWork.ClientRepository.InsertClient(newClient, 1);
        }
    }
}