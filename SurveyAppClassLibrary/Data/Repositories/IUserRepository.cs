using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyAppClassLibrary.Models;

namespace SurveyAppClassLibrary.Data.Repositories
{
    interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserById(int UserId);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int UserId);
        void Save();
    }
}
