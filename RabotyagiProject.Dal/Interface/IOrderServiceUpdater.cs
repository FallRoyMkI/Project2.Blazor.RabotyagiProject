namespace RabotyagiProject.Dal.Interface;

public interface IOrderServiceUpdater
{
    public void UpdateOrderServiceById(int id, int orderId, int serviceId, int workerId, int workload);
}