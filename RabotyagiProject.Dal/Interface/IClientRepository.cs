using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface IClientRepository
{
    public List<ClientDto> GetAllClients();
    public ClientDto GetClientById(int Id);
    public void AddNewClient(ClientDto newDto);
    public void UpdateClientById(ClientDto updatedDto);
}