using agile_project_management_system.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace agile_project_management_system.BLL.DTOs
{
    public class ResourceDTO
    {
        [Key]
        [StringLength(6)]
        [Required]
        public string UserId { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        public string Email { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [StringLength(20)]
        [RegularExpression("Developer|Tester")]
        public string Role { get; set; }

        [Required]
        [ForeignKey("Project")]
        [MaxLength(10)]
        public int ProjectCode { get; set; }

        public Project Project { get; set; }


        public static explicit operator Resource(ResourceDTO dto)
        {
            if (dto == null)
                return null;

            return new Resource
            {
               UserId=dto.UserId,
               FirstName=dto.FirstName,
               LastName=dto.LastName,
               Email=dto.Email,
               PhoneNumber=dto.PhoneNumber,
               Role=dto.Role,
               ProjectCode=dto.ProjectCode



            };
        }

        public static implicit operator ResourceDTO(Resource resource)
        {
            if (resource == null)
                return null;

            return new ResourceDTO
            {
                UserId=resource.UserId,
                FirstName=resource.FirstName,
                LastName=resource.LastName,
                Email=resource.Email,
                PhoneNumber=resource.PhoneNumber,
                Role=resource.Role,
                ProjectCode=resource.ProjectCode

            };
        }

    }
}
