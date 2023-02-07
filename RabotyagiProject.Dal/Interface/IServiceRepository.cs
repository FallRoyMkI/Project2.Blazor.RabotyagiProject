using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface IServiceRepository
{
    public List<ServiceDto> GetAllServices();
    public ServiceDto GetServiceById(int id);
    public void AddNewService(ServiceDto newDto);
    public void UpdateServiceById(ServiceDto updatedDto);
}