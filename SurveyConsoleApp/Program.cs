using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyAppClassLibrary.Data;

namespace SurveyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Repo = new Repository();
            //var _context = Repo.GetContext();
            Console.WriteLine("Test");
            var users = Repo.GetUsers();
            Console.WriteLine("Number of Users: {0}", users.Count());
            foreach(var user in users)
            {
                Console.WriteLine("UserName: {0}", user.Username);
                Console.WriteLine("Clients:");
                foreach(var client in user.Clients)
                {
                    Console.WriteLine("{0} {1}", client.FirstName, client.LastName);
                }
            }
            Console.ReadLine();
        }
    }
}
