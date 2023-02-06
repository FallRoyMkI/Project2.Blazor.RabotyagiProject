using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface IClientGetter
{
    public List<ClientDto> GetAllClients();
    public ClientDto GetClientById(int Id);

}