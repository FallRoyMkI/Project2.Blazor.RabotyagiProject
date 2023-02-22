using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal;

namespace RabotyagiProject.Bll;

public class WorkerManager
{
    private readonly MapperX _mapperX = new();
    private readonly IWorkerRepository _repository;

    public WorkerManager(IWorkerRepository? repository = null)
    {
        _repository = repository ?? new WorkerRepository();
    }


    public List<WorkerOutputModel> GetAllWorkers()
    {
        return _mapperX.MapWorkerDtoListToWorkerOutputModelList(_repository.GetAllWorkers());
    }

    public WorkerOutputModel GetWorkerById(int Id)
    {
        return _mapperX.MapWorkerDtoToWorkerOutputModel(_repository.GetWorkerById(Id));
    }

    public void AddNewWorker(WorkerInputModel model)
    {
        _repository.AddNewWorker(_mapperX.MapWorkerInputModelToWorkerDto(model));
    }

    public void AddNewServiceToWorker(int workerId, ServiceInputModel model)
    {
        _repository.AddNewServiceToWorker(workerId,_mapperX.MapServiceInputModelToServiceDto(model));
    }

    public void UpdateWorkerById(WorkerInputModel model)
    {
        _repository.UpdateWorkerById(_mapperX.MapWorkerInputModelToWorkerDto(model));
    }

    public void UpdateWorkerService(int workerId, ServiceInputModel model)
    {
        _repository.UpdateWorkerService(workerId, _mapperX.MapServiceInputModelToServiceDto(model));
    }
}