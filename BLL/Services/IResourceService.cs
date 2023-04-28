using agile_project_management_system.BLL.DTOs;

namespace agile_project_management_system.BLL.Services
{
    public interface IResourceService
    {
        public bool InsertNewResource(ResourceDTO resource);
    }
}
