
using agile_project_management_system.DAL.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agile_project_management_system.BLL.DTOs
{
    public class ProjectDTO
    {

        [Key]
        public int ProjectCode { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [MaxLength(10)]
        public int Budget { get; set; }

        public DateTime StartDate { get; set; }


        public DateTime ExpectedEndDate { get; set; }

        public DateTime CreatedOn { get; set; }

        [StringLength(20)]
        [RegularExpression("New|InProgress|Completed|Delayed|Cancelled")]
        public string Status { get; set; }

        public DateTime LastUpdatedOn { get; set; }

        [ForeignKey("Client")]
        [MaxLength(10)]
        public int ClientId { get; set; }

        [Required]
        public Client Client { get; set; }

        public static explicit operator Project(ProjectDTO dto)
        {
            if (dto == null)
                return null;

            return new Project
            {
                    ProjectCode=dto.ProjectCode,
                    Title=dto.Title,
                    Budget=dto.Budget,
                    StartDate=dto.StartDate,
                    ExpectedEndDate=dto.ExpectedEndDate,
                    CreatedOn=dto.CreatedOn,
                    Status=dto.Status,
                    LastUpdatedOn=dto.LastUpdatedOn,
                    ClientId=dto.ClientId


               
            };
        }

        public static implicit operator ProjectDTO(Project project)
        {
            if (project == null)
                return null;

            return new ProjectDTO
            {
                    ProjectCode=project.ProjectCode,
                    Title=project.Title,
                    Budget=project.Budget,
                    StartDate=project.StartDate,
                    ExpectedEndDate=project.ExpectedEndDate,
                    CreatedOn=project.CreatedOn,
                    Status=project.Status,
                    LastUpdatedOn=project.LastUpdatedOn,
                    ClientId=project.ClientId
               
            };
        }
    }
}
