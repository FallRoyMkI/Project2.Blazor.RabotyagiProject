using AutoMapper;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Bll.Models;

namespace RabotyagiProject.Bll
{
    public class MapperX
    {
        private MapperConfiguration _configuration;

        public MapperX()
        {
            _configuration = new MapperConfiguration(
                cfg=> cfg.CreateMap<ClientDto, ClientOutputModel>()
                );
        }

        public List<ClientOutputModel> MapClientDtoToClientOutputModel(List<ClientDto> clients)
        {
            return _configuration.CreateMapper().Map<List<ClientOutputModel>>(clients);
        }
    }

}
