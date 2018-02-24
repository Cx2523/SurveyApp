using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyAppClassLibrary.Models;
using System.Data.Entity;

namespace SurveyAppClassLibrary.Data
{
    public class Repository
    {
        public Context GetContext()
        {
            Context context = new Context();
            context.Database.Log = (message) => Debug.WriteLine(message);
            return context;
        }

        public ICollection<User> GetUsers()
        {
            using(Context context = GetContext())
            {
                return context.Users
                    .Include(u => u.Questions)
                    .Include(u => u.Surveys)
                    .Include(u => u.Clients)
                    .ToList();
            }
        }

        public User GetUserById(int id)
        {
            using (Context context = GetContext())
            {
                return context.Users.Find(id);
            }
        }

        public void AddUser(User user)
        {
            using (Context context = GetContext())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
