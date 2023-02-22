using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Bll;

public class ClientManager
{
    private readonly MapperX _mapperX = new();
    private readonly IClientRepository _repository;

    public ClientManager(IClientRepository? repository = null)
    {
        _repository = repository ?? new ClientRepository();
    }


    public List<ClientOutputModel> GetAllClients()
    {
        return _mapperX.MapClientDtoListToClientOutputModelList(_repository.GetAllClients());
    }

    public ClientOutputModel GetClientById(int Id)
    {
        return _mapperX.MapClientDtoToClientOutputModel(_repository.GetClientById(Id));
    }

    public void AddClient(ClientInputModel model)
    {
        _repository.AddNewClient(_mapperX.MapClientInputModelToClientDto(model));
    }

    public void UpdateClientById(ClientInputModel model)
    {
        _repository.UpdateClientById(_mapperX.MapClientInputModelToClientDto(model));
    }
}