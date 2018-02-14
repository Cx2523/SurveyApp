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
        public int Id { get; set; }
        User Creator { get; set; }
        DateTime CreationDate { get; set; }
        string QuestionText { get; set; }
    }
}
