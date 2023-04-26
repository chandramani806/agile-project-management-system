using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agile_project_management_system.DAL.Models
{
    public class Project
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
    }
}
