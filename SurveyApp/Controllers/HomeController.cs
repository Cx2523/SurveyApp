﻿using System;
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
    }
}