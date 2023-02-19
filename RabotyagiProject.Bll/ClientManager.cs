using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Options;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal;
using AutoMapper;

namespace RabotyagiProject.Bll
{
    public class ClientManager
    {
        MapperX _mapperX = new MapperX();
        public IClientRepository ClientRepository { get; set; }

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
}
