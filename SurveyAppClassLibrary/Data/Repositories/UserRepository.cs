﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyAppClassLibrary.Models;
using System.Data.Entity;

namespace SurveyAppClassLibrary.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        // the User Repository would be basically an admin layer over
        // the standard User interface. for now it is just stubbed 
        // except to get a specific User based on username and email.
        private Context _context = null;
        public UserRepository(Context context)
        {
            _context = context; 
        }

        //public IEnumerable<User> GetUsers() { }

        //public User GetUserById(int id) { } 

        public User GetUserByUsernameAndEmail(string username, string email)
        {
            return _context.Users.Find(username); 
        }

        public void InsertUser(User user) { }

        public void UpdateUser(User user) { }

        public void DeleteUser(int UserId) { }

        public void Save() { }
    }
}
