using SurveyAppClassLibrary.Data.Repositories;
using SurveyAppClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurveyApp.Controllers
{
    public class ClientController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public ActionResult Index()
        {
            return View();
        }

        public void InsertClient(Client client)
        {
            unitOfWork.ClientRepository.InsertClient(client, (int)Session["UserId"]);
            unitOfWork.Save();
        }
    }
}