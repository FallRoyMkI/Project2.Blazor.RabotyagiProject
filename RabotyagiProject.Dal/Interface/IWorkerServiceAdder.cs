namespace RabotyagiProject.Dal.Interface;

public interface IWorkerServiceAdder
{
    public void AddNewServiceToWorker(int workerId, int serviceId, int cost);
}