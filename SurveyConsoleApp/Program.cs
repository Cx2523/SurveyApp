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
            var Repo = new Repository();

            string status = "run";
            do
            {
                var users = Repo.GetUsers();
                Console.WriteLine("Number of Users: {0}", users.Count());
                foreach (var user in users)
                {
                    Console.WriteLine("UserName: {0}", user.Username);
                    Console.WriteLine("Clients:");
                    foreach (var client in user.Clients)
                    {
                        Console.WriteLine("{0} {1}", client.FirstName, client.LastName);
                    }
                }

                Console.WriteLine("Select a User by Id: ");
                var stringSelection = Console.ReadLine();
                var intSelection = Int32.Parse(stringSelection);
                var queriedUser = Repo.GetUserById(intSelection);
                Console.WriteLine("UserName: {0}", queriedUser.Username);

                User newUser = new User() { };
                Console.WriteLine("\nCreate new user:");
                Console.Write("Username: ");
                newUser.Username = Console.ReadLine();
                Console.Write("Email: ");
                newUser.Email = Console.ReadLine();

                Repo.AddUser(newUser);

                Console.Write("\nType \'quit\' to quit or any enter to continue: ");
                status = Console.ReadLine();
            } while (status != "quit");

        }
    }
}
