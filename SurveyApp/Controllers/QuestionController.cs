using SurveyApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SurveyAppClassLibrary.Data.Repositories;
using SurveyAppClassLibrary.Data;
using SurveyAppClassLibrary.Models;

namespace SurveyApp.Controllers
{
    public class QuestionController : Controller
    {
        private QuestionRepository QuestionRepo = null;
        private Context _context = null;

        public QuestionController()
        {
            _context = new Context();
            QuestionRepo = new QuestionRepository(_context);
        }

        public ActionResult Index()
        {
            QuestionManagement questions = new QuestionManagement();
            questions.Questions = QuestionRepo.GetQuestions((int)Session["UserId"]).ToList();
            return View(questions);
        }

        [HttpPost]
        public ActionResult InsertQuestion(Question question)
        {
            QuestionRepo.InsertQuestion(question, (int)Session["UserId"]);
            QuestionRepo.Save();
            return RedirectToAction("Index");
        } 

        public ActionResult DeleteQuestion(int id)
        {
            QuestionRepo.DeleteQuestion(id);
            QuestionRepo.Save();
            return RedirectToAction("Index");
        }


    }
}