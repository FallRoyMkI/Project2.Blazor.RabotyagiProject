using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Bll;

public class ServiceManager
{
    private readonly MapperX _mapperX = new();
    private readonly IServiceRepository _repository;

    public ServiceManager(IServiceRepository? repository = null)
    {
        _repository = repository ?? new ServiceRepository();
    }


    public List<ServiceOutputModel> GetAllServices()
    {
        return _mapperX.MapServiceDtoListToServiceOutputModelList(_repository.GetAllServices());
    }

    public ServiceOutputModel GetServiceById(int id)
    {
        return _mapperX.MapServiceDtoToServiceOutputModel(_repository.GetServiceById(id));
    }

    public void UpdateServiceById(ServiceInputModel model)
    {
        _repository.UpdateServiceById(_mapperX.MapServiceInputModelToServiceDto(model));
    }

    public void AddNewService(ServiceInputModel model)
    {
        _repository.AddNewService(_mapperX.MapServiceInputModelToServiceDto(model));
    }

}