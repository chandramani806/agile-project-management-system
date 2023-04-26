
using agile_project_management_system.DAL.Data;
using agile_project_management_system.DAL.Models;

namespace agile_project_management_system.DAL.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        AppDbContext db;

        public ProjectRepository(AppDbContext db)
        {
            this.db = db;
        }

        public bool InsertNewProject(Project project)
        {
            db.Projects.Add(project);
            return db.SaveChanges() > 0;
        }

        public bool UpdateNewProject(int code, Project project)
        {
            Project p = db.Projects.SingleOrDefault(x => x.ProjectCode == code);
            if (p == null)
                return false;

            p = project;
            return db.SaveChanges() > 0;
        }

        public List<Project> GetProject()
        {
            return db.Projects.ToList();
        }


    }
}
