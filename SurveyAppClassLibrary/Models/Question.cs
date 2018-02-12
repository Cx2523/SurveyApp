using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppClassLibrary.Models
{
    public class Question
    {
        int QuestionId { get; set; }
        User Creator { get; set; }
        DateTime CreationDate { get; set; }
        string QuestionText { get; set; }
    }
}
