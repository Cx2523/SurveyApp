using SurveyAppClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyAppClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Context context = new Context())
            {
                context.Users.Add(new User()
                {

                });
            }
        }
    }
}
