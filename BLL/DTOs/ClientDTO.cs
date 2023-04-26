using agile_project_management_system.DAL.Models;
using System.ComponentModel.DataAnnotations;

namespace agile_project_management_system.BLL.DTOs
{
    public class ClientDTO
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

        public static explicit operator Client(ClientDTO dto)
        {
            if (dto == null)
                return null;

            return new Client
            {
                id = dto.id,
                Name = dto.Name,
                POC_FullName = dto.POC_FullName,
                POC_PhoneNumber = dto.POC_PhoneNumber,
                POC_EmailAddress = dto.POC_EmailAddress
            };
        }

        public static implicit operator ClientDTO(Client client)
        {
            if (client == null)
                return null;

            return new ClientDTO
            {
                id = client.id,
                Name = client.Name,
                POC_FullName = client.POC_FullName,
                POC_PhoneNumber = client.POC_PhoneNumber,
                POC_EmailAddress = client.POC_EmailAddress
            };
        }
    }
}
