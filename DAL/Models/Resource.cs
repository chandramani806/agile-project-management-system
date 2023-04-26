using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agile_project_management_system.DAL.Models
{
    public class Resource
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

    }
}
