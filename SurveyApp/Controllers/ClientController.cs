using SurveyApp.ViewModels;
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
            ClientManagement clients = new ClientManagement();
            clients.Clients = unitOfWork.ClientRepository.GetClients((int)Session["UserId"]).ToList();
            
            return View(clients);
        }

        [HttpPost]
        public ActionResult InsertClient(Client client)
        {
            unitOfWork.ClientRepository.InsertClient(client, (int)Session["UserId"]);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteClient()
        {
            unitOfWork.ClientRepository.DeleteClient(
                Int32.Parse(Request.QueryString["clientID"])
                );
            unitOfWork.Save();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public void EditClient()
        {
            //shouldn't need to gao back to the database
            Client clientToEdit = unitOfWork.ClientRepository.GetClientById(Int32.Parse(Request.QueryString["clientID"]));
            ViewBag.clientToEdit = clientToEdit;
        }

        [HttpPost]
        public ActionResult EditClient(Client client)
        {

            return RedirectToAction("Index");
        }
    }
}