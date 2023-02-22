using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface IWorkerRepository
{
    public List<WorkerDto> GetAllWorkers();
    public WorkerDto GetWorkerById(int Id);
    public void AddNewWorker(WorkerDto newDto);
    public void AddNewServiceToWorker(int workerId, ServiceDto newDto);
    public void UpdateWorkerById(WorkerDto updatedDto);
    public void UpdateWorkerService(int workerId, ServiceDto updatedDto);
}