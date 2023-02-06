using Dapper;
using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Dal;

public class OrderRepository : IOrderGetter, IOrderAdder, IOrderUpdater, IOrderServiceAdder, IOrderServiceUpdater
{
    public List<OrderDto> GetAllOrders()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            
            sqlConnection.Open();
            var result = sqlConnection.Query<OrderDto>(Options.StoredProceduresNames.GetAllOrders,
                commandType: CommandType.StoredProcedure).ToList();
            foreach (var order in result)
            {
                order.Services = GetAllOrderServicesByOrderId(order.Id);
            }
            return result;
        }
    }
    public List<OrderDto> GetAllOrdersByClientId(int id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            var result = sqlConnection.Query<OrderDto>(Options.StoredProceduresNames.GetAllOrdersByClientId,
                new { id }, commandType: CommandType.StoredProcedure).ToList();
            foreach (var order in result)
            {
                order.Services = GetAllOrderServicesByOrderId(order.Id);
            }
            return result;
        }
    }
    public List<OrderDto> GetAllCompletedOrders()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            var result = sqlConnection.Query<OrderDto>(Options.StoredProceduresNames.GetAllCompletedOrders,
                commandType: CommandType.StoredProcedure).ToList();
            foreach (var order in result)
            {
                order.Services = GetAllOrderServicesByOrderId(order.Id);
            }
            return result;
        }
    }
    public List<OrderDto> GetAllNotCompletedOrders()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            var result = sqlConnection.Query<OrderDto>(Options.StoredProceduresNames.GetAllNotCompletedOrders,
                commandType: CommandType.StoredProcedure).ToList();
            foreach (var order in result)
            {
                order.Services = GetAllOrderServicesByOrderId(order.Id);
            }
            return result;
        }
    }
    public OrderDto GetOrderById(int id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            var result = sqlConnection.QueryFirst<OrderDto>(Options.StoredProceduresNames.GetOrderById,
                new { id }, commandType: CommandType.StoredProcedure);
            result.Services = GetAllOrderServicesByOrderId(result.Id);
            return result;
        }
    }
    public void AddNewOrder(int clientId, string adress, DateTime date)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.AddNewOrder,
                new { clientId, adress, date }, commandType: CommandType.StoredProcedure);
        }
    }
    public void AddNewServiceToOrder(int orderId, int serviceId, int workload)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.AddNewServiceToOrder,
                new { orderId, serviceId, workload }, commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateOrderById(int id, int clientId, bool isCompleted, string adress, DateTime date, int cost, Options.Rate rate, string report, bool isDeleted )
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.UpdateOrderById,
                new { id, clientId, isCompleted, adress, date, cost, rate, report, isDeleted }, commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateOrderServiceById(int id, int orderId, int serviceId, int workerId, int workload)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.UpdateOrderServiceById,
                new { id, orderId, serviceId, workerId, workload }, commandType: CommandType.StoredProcedure);
        }
    }
    private List<ServiceWorkerDto> GetAllOrderServicesByOrderId(int id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<ServiceWorkerDto>(Options.StoredProceduresNames.GetAllOrderServicesByOrderId,
                new { id }, commandType: CommandType.StoredProcedure).ToList();

        }
    }
}