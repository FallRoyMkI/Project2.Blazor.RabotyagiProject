using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal.Interface;

public interface IOrderGetter
{
    public List<OrderDto> GetAllOrders();
    public OrderDto GetOrderById(int id);
    public List<OrderDto> GetAllOrdersByClientId(int id);
    public List<OrderDto> GetAllCompletedOrders();
    public List<OrderDto> GetAllNotCompletedOrders();
}