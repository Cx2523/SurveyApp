﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyAppClassLibrary.Models;

namespace SurveyAppClassLibrary.Data.Repositories
{
    interface IClientRepository
    {
        IEnumerable<Client> GetClients(int UserId);
        Client GetClientById(int ClientId);
        void InsertClient(Client Client, int UserId);
        void UpdateClient(Client Client);
        void DeleteClient(int ClientId);
        void Save();
    }
}
