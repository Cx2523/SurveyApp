using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SurveyAppClassLibrary.Models;


namespace SurveyAppClassLibrary.Data.Repositories
{

    public class ClientRepository : IClientRepository
    {
        private Context _context = null;
        public ClientRepository(Context context)
        {
            _context = context;
        }

        public IEnumerable<Client> GetClients()
        {

            return _context.Clients.ToList();
        }

        public Client GetClientById(int id)
        {
            var query = from c in _context.Clients where c.Id == id select c;
            return query.Single();
        }

        public void InsertClient(Client client)
        {
            _context.Users.Find(client.OwnerId).Clients.Add(client);
        }

        public void UpdateClient(Client client) { }

        public void DeleteClient(int ClientId) { }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
