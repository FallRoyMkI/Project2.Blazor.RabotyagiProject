using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal;

namespace RabotyagiProject.Bll
{
    public class ServiceManager
    {
        MapperX _mapperX = new MapperX();

        public IServiceRepository ServiceRepository { get; set; }

        public ServiceManager(IServiceRepository repository = null)
        {
            if(repository != null)
            {
            ServiceRepository = repository;
            }
            else
            {
                ServiceRepository = new ServiceRepository();
            }
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
