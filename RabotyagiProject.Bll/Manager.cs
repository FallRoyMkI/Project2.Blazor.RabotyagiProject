using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Options;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal;
using AutoMapper;
namespace RabotyagiProject.Bll
{
    public class Manager
    {
        MapperX _mapperX = new MapperX();

        public List<ClientOutputModel> GetAllClients()
        {
            ClientRepository cp = new ClientRepository();
            var clients = cp.GetAllClients();
            var result = _mapperX.MapClientDtoToClientOutputModel(clients);
            return result;
        }
    }
}