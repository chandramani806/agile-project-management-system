using agile_project_management_system.DAL.Data;
using agile_project_management_system.DAL.Models;

namespace agile_project_management_system.DAL.Repository
{
    public class ClientRepository : IClientRepository
    {
        AppDbContext db;

        public ClientRepository(AppDbContext db)
        {
            this.db = db;
        }
        public List<Client> GetClients()
        {
            return db.Clients.ToList();
        }
    }
}
