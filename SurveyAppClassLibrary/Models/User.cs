﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppClassLibrary.Models
{
    public class User
    {
        int UserId { get; set; }
        string Username { get; set; }
        string Email { get; set; }
        DateTime CreationDate { get; set; }
        List<Survey> Surveys { get; set; }
        List<Question> Questions { get; set; }
    }
}
