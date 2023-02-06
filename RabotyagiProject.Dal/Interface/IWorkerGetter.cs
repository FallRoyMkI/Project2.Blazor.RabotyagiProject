using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface IWorkerGetter
{
    public List<WorkerDto> GetAllWorkers();
    public WorkerDto GetWorkerById(int Id);
}