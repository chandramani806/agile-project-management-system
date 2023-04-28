using agile_project_management_system.BLL.DTOs;
using agile_project_management_system.DAL.Models;
using agile_project_management_system.DAL.Repository;

namespace agile_project_management_system.BLL.Services
{
    public class ResourceService : IResourceService
    {
        public readonly IResourceRepository resourceRepository;
        public ResourceService(IResourceRepository resourceRepository)
        {
            this.resourceRepository = resourceRepository;
        }
        
            public bool InsertNewResource(ResourceDTO resource)
            {
                return resourceRepository.InsertNewResource((Resource)resource);
                
            }

        

    }
}
