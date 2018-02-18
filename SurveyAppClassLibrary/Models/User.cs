using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppClassLibrary.Models
{
    public class User
    {
        public User()
        {
            Questions = new List<Question> { };
            Surveys = new List<Survey> { };
            Clients = new List<Client> { };
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<Survey> Surveys {get; set;}
        public ICollection<Client> Clients { get; set; }
    }
}
