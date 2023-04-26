
using agile_project_management_system.DAL.Data;
using agile_project_management_system.DAL.Models;

namespace agile_project_management_system.DAL.Repository
{
    public class ResourceRepository
    {
        AppDbContext db;

        public ResourceRepository(AppDbContext db)
        {
            this.db = db;
        }

        public bool InsertNewResource(Resource resource)
        {
            db.Resources.Add(resource);
            return db.SaveChanges() > 0;
        }
    }
}
