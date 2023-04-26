using agile_project_management_system.BLL.DTOs;
using agile_project_management_system.DAL.Repository;

namespace agile_project_management_system.BLL.Services
{
    public class ClientService : IClientService
    {
        public readonly IClientRepository clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public List<ClientDTO> GetClients()
        {
            return clientRepository.GetClients().Select(client => (ClientDTO)client).ToList();
        }
    }
}
