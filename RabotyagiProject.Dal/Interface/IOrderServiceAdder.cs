namespace RabotyagiProject.Dal.Interface;

public interface IOrderServiceAdder
{
    public void AddNewServiceToOrder(int orderId, int serviceId, int workload)
}