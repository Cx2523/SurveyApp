using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppClassLibrary.Models
{
    public class Question
    {
        public Question()
        {
            Surveys = new List<Survey> { };
        }
        public int Id { get; set; }
        public User Creator { get; set; }
        public DateTime CreationDate { get; set; }
        public string QuestionText { get; set; }
        public ICollection<Survey> Surveys { get; set; }
    }
}
