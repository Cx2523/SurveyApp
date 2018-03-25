using SurveyAppClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SurveyApp.ViewModels
{
    public class QuestionManagement
    {
        public List<Question> Questions { get; set; }
        public Question Question { get; set; }
    }
}