namespace RabotyagiProject.Dal.Interface;

public interface IWorkerServiceUpdater
{
    public void UpdateWorkerService(int workerId, int serviceId, int cost, bool isDeleted);
}