using agile_project_management_system.DAL.Models;

namespace agile_project_management_system.DAL.Repository
{
    public interface IResourceRepository
    {
        public bool InsertNewResource(Resource resource);
    }
}
