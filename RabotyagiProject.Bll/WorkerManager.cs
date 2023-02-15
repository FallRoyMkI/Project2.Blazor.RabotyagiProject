using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Bll;

public class WorkerManager
{
    MapperX _mapperX = new MapperX();
    public IWorkerRepository WorkerRepository { get; set; }
    public WorkerManager(IWorkerRepository repository = null)
    {
        if (repository != null)
        {
            WorkerRepository = repository;
        }
        else
        {
            WorkerRepository = new WorkerRepository();
        }
    }


    public List<WorkerOutputModel> GetAllWorkers()
    {
        var workers = WorkerRepository.GetAllWorkers();
        var result = _mapperX.MapWorkerDtoToListWorkerOutputModel(workers);
        return result;
    }

    public WorkerOutputModel GetWorkerById(int Id)
    {
        var workers = WorkerRepository.GetWorkerById(Id);
        var result = _mapperX.MapWorkerDtoToWorkerOutputModelById(workers);
        return result;
    }
}