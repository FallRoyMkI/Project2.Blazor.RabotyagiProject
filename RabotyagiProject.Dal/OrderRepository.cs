using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal.Options;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

namespace RabotyagiProject.Dal;

public class OrderRepository : IOrderRepository
{
    public List<OrderDto> GetAllOrders()
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        var result = sqlConnection.Query<OrderDto>(StoredProceduresNames.GetAllOrders,
            commandType: CommandType.StoredProcedure).ToList();
        foreach (var order in result)
        {
            order.Services = GetAllOrderServicesByOrderId(order.Id);
        }
        return result;
    }

    public List<OrderDto> GetAllOrdersByClientId(int id)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        var result = sqlConnection.Query<OrderDto>(StoredProceduresNames.GetAllOrdersByClientId,
            new { id }, 
            commandType: CommandType.StoredProcedure).ToList();
        foreach (var order in result)
        {
            order.Services = GetAllOrderServicesByOrderId(order.Id);
        }
        return result;
    }

    public List<OrderDto> GetAllCompletedOrders()
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        var result = sqlConnection.Query<OrderDto>(StoredProceduresNames.GetAllCompletedOrders,
            commandType: CommandType.StoredProcedure).ToList();
        foreach (var order in result)
        {
            order.Services = GetAllOrderServicesByOrderId(order.Id);
        }
        return result;
    }

    public List<OrderDto> GetAllNotCompletedOrders()
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        var result = sqlConnection.Query<OrderDto>(StoredProceduresNames.GetAllNotCompletedOrders,
            commandType: CommandType.StoredProcedure).ToList();
        foreach (var order in result)
        {
            order.Services = GetAllOrderServicesByOrderId(order.Id);
        }
        return result;
    }

    public OrderDto GetOrderById(int id)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        var result = sqlConnection.QueryFirst<OrderDto>(StoredProceduresNames.GetOrderById,
            new { id }, 
            commandType: CommandType.StoredProcedure);
        result.Services = GetAllOrderServicesByOrderId(result.Id);
        return result;
    }

    public void AddNewOrder(OrderDto newDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.AddNewOrder,
            new { newDto.ClientId, newDto.Adress, newDto.Date }, 
            commandType: CommandType.StoredProcedure);
    }

    public void AddNewServiceToOrder(int orderId, int serviceId, int workload)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.AddNewServiceToOrder,
            new { orderId, serviceId, workload }, 
            commandType: CommandType.StoredProcedure);
    }

    public void UpdateOrderById(OrderDto updatedDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.UpdateOrderById,
            new { updatedDto.Id, updatedDto.ClientId, updatedDto.IsCompleted, updatedDto.Adress, 
                updatedDto.Date, updatedDto.Cost, updatedDto.Rate, updatedDto.Report, updatedDto.IsDeleted }, 
            commandType: CommandType.StoredProcedure);
    }

    public void UpdateOrderServiceById(int id, int orderId, ServiceWorkerDto updatedDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.UpdateOrderServiceById,
            new { id, orderId, updatedDto.ServiceId, updatedDto.WorkerId, updatedDto.Workload }, 
            commandType: CommandType.StoredProcedure);
    }

    private List<ServiceWorkerDto> GetAllOrderServicesByOrderId(int id)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        return sqlConnection.Query<ServiceWorkerDto>(StoredProceduresNames.GetAllOrderServicesByOrderId,
            new { id }, 
            commandType: CommandType.StoredProcedure).ToList();
    }
}