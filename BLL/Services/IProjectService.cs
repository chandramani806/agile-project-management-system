using agile_project_management_system.BLL.DTOs;
using agile_project_management_system.DAL.Models;

namespace agile_project_management_system.BLL.Services
{
    public interface IProjectService

    {
        public bool InsertNewProject(ProjectDTO project);
        public bool UpdateNewProject(int code, ProjectDTO project);
        public List<ProjectDTO> GetProject();
    }
}
