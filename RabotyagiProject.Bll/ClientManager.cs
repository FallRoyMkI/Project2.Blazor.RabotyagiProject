using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal;
using RabotyagiProject.Bll.Models;

namespace RabotyagiProject.Bll;

public class ClientManager
{
    MapperX _mapperX = new MapperX();
    public IClientRepository ClientRepository { get; set; }
    public ClientManager(IClientRepository repository = null)
    {
        if (repository != null)
        {
            ClientRepository = repository;
        }
        else
        {
            ClientRepository = new ClientRepository();
        }
    }

    public List<ClientOutputModel> GetAllClients()
    {
        var clients = ClientRepository.GetAllClients();
        var result = _mapperX.MapClientDtoToListClientOutputModel(clients);
        return result;
    }

    public ClientOutputModel GetClientById(int Id)
    {
        var client = ClientRepository.GetClientById(Id);
        var result = _mapperX.MapClientDtoToClientOutputModelById(client);
        return result;
    }
}