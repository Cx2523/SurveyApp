using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SurveyAppClassLibrary.Models;

namespace SurveyApp.ViewModels
{
    public class ClientManagement
    {
        public List<Client> Clients { get; set; }
        public Client Client { get; set; }
    }
}