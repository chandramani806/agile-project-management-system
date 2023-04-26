using agile_project_management_system.DAL.Models;

namespace agile_project_management_system.DAL.Repository
{
    public interface IProjectRepository
    {
        public bool InsertNewProject(Project project);
        public bool UpdateNewProject(int code, Project project);
        public List<Project> GetProject();
    }
}
