using agile_project_management_system.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace agile_project_management_system.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Resource> Resources { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Client> Clients { get; set; }


    }
}
