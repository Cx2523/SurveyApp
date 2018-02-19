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
            var DB = new DatabaseInitializer();
            Console.WriteLine("Test");
            Console.ReadLine();
        }
    }
}
