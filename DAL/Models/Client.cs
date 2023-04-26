using System.ComponentModel.DataAnnotations;

namespace agile_project_management_system.DAL.Models
{
    public class Client
    {
        [Key]
        [MaxLength(10)]
        public int id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(10)]
        public string POC_FullName { get; set; }

        [StringLength(16)]
        public string POC_PhoneNumber { get; set; }

        [StringLength(100)]
        public string POC_EmailAddress { get; set; }
    }
}
