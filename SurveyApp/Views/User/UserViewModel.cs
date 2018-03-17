using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SurveyAppClassLibrary.Models;

namespace SurveyAppWeb
{
    public class UserViewModel
    {
        public User User { get; set; }
        public Client Client { get; set; }
    }
}