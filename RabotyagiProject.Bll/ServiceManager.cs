using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Bll
{
    public class ServiceManager
    {
        MapperX _mapperX = new MapperX();

        public IServiceRepository ServiceRepository { get; set; }

        public ServiceManager(IServiceRepository repository)
        {
            ServiceRepository=repository;
        }

        public List<ServiceOutputModel> GetAllServices()
        {
            var services = ServiceRepository.GetAllServices();
            var result = _mapperX.MapServiceDtoToServiceOutputModel(services);
            return result;
        }

        public ServiceOutputModel GetServiceById(int id)
        {
            var serviceById = ServiceRepository.GetServiceById(id);
            var result = _mapperX.MapServiceDtoToServiceOutputModelById(serviceById);
            return result;
        }
    }
}
