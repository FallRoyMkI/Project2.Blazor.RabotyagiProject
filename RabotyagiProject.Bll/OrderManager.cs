using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Bll;

public class OrderManager
{
    private readonly MapperX _mapperX = new();
    private readonly IOrderRepository _repository;

    public OrderManager(IOrderRepository? repository = null)
    {
        _repository = repository ?? new OrderRepository();
    }


    public List<OrderOutputModel> GetAllOrders()
    {
        return _mapperX.MapOrderDtoListToOrderOutputModelList(_repository.GetAllOrders());
    }

    public List<OrderOutputModel> GetAllCompletedOrders()
    {
        return _mapperX.MapOrderDtoListToOrderOutputModelList(_repository.GetAllCompletedOrders());
    }

    public List<OrderOutputModel> GetAllNotCompletedOrders()
    {
        return _mapperX.MapOrderDtoListToOrderOutputModelList(_repository.GetAllNotCompletedOrders());
    }

    public List<OrderOutputModel> GetAllOrdersByClientId(int id)
    {
        return _mapperX.MapOrderDtoListToOrderOutputModelList(_repository.GetAllOrdersByClientId(id));
    }

    public OrderOutputModel GetOrderById(int id)
    {
        return _mapperX.MapOrderDtoToOrderOutputModel(_repository.GetOrderById(id));
    }

    public void AddNewOrder(OrderInputModel model)
    {
        if (new ClientRepository().GetClientById(model.ClientId).IsDeleted == false)
        {
            _repository.AddNewOrder(_mapperX.MapOrderInputModelToOrderDto(model));
        }
    }

    public void AddNewServiceToOrder(int orderId, int serviceId, int workload)
    {
        _repository.AddNewServiceToOrder(orderId,  serviceId, workload);
    }

    public void UpdateOrderById(OrderInputModel model)
    {
        _repository.UpdateOrderById(_mapperX.MapOrderInputModelToOrderDto(model));
    }

    public void UpdateOrderServiceById(int orderId, ServiceWorkerInputModel model)
    {
        _repository.UpdateOrderServiceById(orderId, _mapperX.MapServiceWorkerInputModelToServiceWorkerDto(model));
    }
}