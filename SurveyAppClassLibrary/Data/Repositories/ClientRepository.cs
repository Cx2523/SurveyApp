using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public IEnumerable<Client> GetClients(int id)
        {
            return _context.Clients
                .Where(client => client.Owner.Id == id)
                .Include(client => client.Surveys)
                .Include(client => client.Owner)
                .ToList();
        }

        public Client GetClientById(int id)
        {
            var query = from c in _context.Clients where c.Id == id select c;
            return query.Single();
        }

        public void InsertClient(Client client, int UserId)
        {
            _context.Users.Find(UserId).Clients.Add(client);
        }

        public void UpdateClient(Client client) { }

        public void DeleteClient(int ClientId)
        {
            Client client = _context.Clients.Where(c => c.Id == ClientId).SingleOrDefault();
            _context.Clients.Remove(client);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
