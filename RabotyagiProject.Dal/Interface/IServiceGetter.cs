using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface IServiceGetter
{
    public List<ServiceDto> GetAllServices();
    public ServiceDto GetServiceById(int id);
}