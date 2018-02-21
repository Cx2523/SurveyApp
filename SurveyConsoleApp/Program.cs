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
            var _context = Repo.GetContext();
            Console.WriteLine("Test");
            Console.ReadLine();
        }
    }
}
