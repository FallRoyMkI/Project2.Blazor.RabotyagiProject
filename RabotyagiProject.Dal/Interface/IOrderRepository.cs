using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface IOrderRepository
{
    public List<OrderDto> GetAllOrders();
    public OrderDto GetOrderById(int id);
    public List<OrderDto> GetAllOrdersByClientId(int id);
    public List<OrderDto> GetAllCompletedOrders();
    public List<OrderDto> GetAllNotCompletedOrders();
    public void AddNewOrder(OrderDto newDto);
    public void AddNewServiceToOrder(int orderId, int serviceId, int workload);
    public void UpdateOrderById(OrderDto updatedDto);
    public void UpdateOrderServiceById(int id, int orderId, ServiceWorkerDto updatedDto);
}