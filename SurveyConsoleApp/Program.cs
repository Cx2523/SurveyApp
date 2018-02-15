using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyAppClassLibrary.Data;
using SurveyAppClassLibrary.Models;

namespace SurveyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var _context = new Context())
            {
                _context.Users.Add(new User()
                {
                    Username = "testuser1",
                    Email = "test@test.com",
                    CreationDate = DateTime.Today
                });
            };

            Console.WriteLine("Test");
            Console.ReadLine();

        }
    }
}
