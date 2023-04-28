

using agile_project_management_system.BLL.DTOs;
using agile_project_management_system.DAL.Models;
using agile_project_management_system.DAL.Repository;

namespace agile_project_management_system.BLL.Services
{
    public class ProjectService : IProjectService
    {
        public readonly IProjectRepository projectRepository;
        public ProjectService(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public bool InsertNewProject(ProjectDTO project)
        {

            return projectRepository.InsertNewProject((Project) project);
        }

        public bool UpdateNewProject(int code, ProjectDTO project)
        {
            return projectRepository.UpdateNewProject(code, (Project)project);
        }

        public List<ProjectDTO> GetProject()
        {
            return projectRepository.GetProject().Select(x => (ProjectDTO)x).ToList();
        }
    }
}
