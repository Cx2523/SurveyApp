using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SurveyAppClassLibrary.Models;

namespace SurveyAppClassLibrary.Data
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        public DatabaseInitializer()
        {
            Seed(new Context());
        }

        protected override void Seed(Context _context)
        {

            User TestUser1 = new User()
            {
                Username = "testuser1",
                Email = "test@test.com",
                CreationDate = DateTime.Today
            };

            Survey Survey1 = new Survey()
            {
                Creator = TestUser1,
                CreationDate = DateTime.Today
            };

            Question Q1 = new Question()
            {
                Creator = TestUser1,
                CreationDate = DateTime.Today,
                QuestionText = "How are you feeling today?"
            };
            Question Q2 = new Question()
            {
                Creator = TestUser1,
                CreationDate = DateTime.Today,
                QuestionText = "How would you rate our product?"
            };

            _context.Users.Add(TestUser1);
            _context.Questions.Add(Q1);
            _context.Questions.Add(Q2);
            _context.Surveys.Add(Survey1);

            _context.SaveChanges();
            
        }
    }
}
