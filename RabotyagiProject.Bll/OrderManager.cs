using RabotyagiProject.Bll.Models;
using RabotyagiProject.Dal.Options;
using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal;
using AutoMapper;

namespace RabotyagiProject.Bll;

public class OrderManager
{
    MapperX _mapperX = new MapperX();
    public IOrderRepository OrderRepository { get; set; }

    public OrderManager(IOrderRepository repository = null)
    {
        if (repository != null)
        {
            OrderRepository = repository;
        }
        else
        {
            OrderRepository = new OrderRepository();
        }
    }

    public List<OrderOutputModel> GetAllOrders()
    {
        var orders = OrderRepository.GetAllOrders();
        var result = _mapperX.MapOrderDtoToListOrderOutputModel(orders);
        return result;
    }

    public List<OrderOutputModel> GetAllCompletedOrders()
    {
        var completedOrders = OrderRepository.GetAllCompletedOrders();
        var result = _mapperX.MapOrderDtoToListOrderOutputModel(completedOrders);
        return result;
    }

    public List<OrderOutputModel> GetAllNotCompletedOrders()
    {
        var notCompletedOrders = OrderRepository.GetAllNotCompletedOrders();
        var result = _mapperX.MapOrderDtoToListOrderOutputModel(notCompletedOrders);
        return result;
    }

    public List<OrderOutputModel> GetAllOrdersByClientId(int id)
    {
        var сlientOrders = OrderRepository.GetAllOrdersByClientId(id);
        var result = _mapperX.MapOrderDtoToListOrderOutputModelById(сlientOrders);
        return result;
    }

    public OrderOutputModel GetOrderById(int id)
    {
        var orders = OrderRepository.GetOrderById(id);
        var result = _mapperX.MapOrderDtoToOrderOutputModelById(orders);
        return result;
    }
}