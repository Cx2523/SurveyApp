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
        //private Context _context = null;

        private int userID;

        public int UserID {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }

        //public UserController()
        //{
        //    _context = new Context();
        //}

        
        public ActionResult Index(User user)
        {
            userID = user.Id;
            return View(user);
        }

        public void GetClients()
        {
            ClientRepository ClientRepo = new ClientRepository(_context);
            ViewBag.Clients = ClientRepo.GetClients(UserID);
        }

        public void InsertClient(Client newClient)
        {
            ClientRepository ClientRepo = new ClientRepository(_context);
            ClientRepo.InsertClient(newClient, UserID);
            ClientRepo.Save();
            RedirectToAction("Index");
        }
    }
}