using Dapper;
using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;

namespace RabotyagiProject.Dal;

public class OrderProcedures
{
    public List<OrderDto> GetAllOrders()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<OrderDto>(Options.StoredProcedures.GetAllOrders,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public List<OrderDto> GetAllOrdersByClientId(int id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<OrderDto>(Options.StoredProcedures.GetAllOrdersByClientId,
                new { id }, commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public List<OrderDto> GetAllCompletedOrders()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<OrderDto>(Options.StoredProcedures.GetAllCompletedOrders,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public List<OrderDto> GetAllNotCompletedOrders()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<OrderDto>(Options.StoredProcedures.GetAllNotCompletedOrders,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public OrderDto GetOrderById(int id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.QueryFirst<OrderDto>(Options.StoredProcedures.GetOrderById,
                new { id }, commandType: CommandType.StoredProcedure);
        }
    }
    public void AddNewOrder(int clientId, string adress, DateOnly date)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.AddNewOrder,
                new { clientId, adress, date }, commandType: CommandType.StoredProcedure);
        }
    }
    public void AddNewServiceToOrder(int orderId, int serviceId, int workload)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.AddNewServiceToOrder,
                new { orderId, serviceId, workload }, commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateOrderById(int id, int clientId, bool isCompleted, string adress, DateOnly date, int cost, Options.Rate rate, string report, bool isDeleted )
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.UpdateOrderById,
                new { id, clientId, isCompleted, adress, date, cost, rate, report, isDeleted }, commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateOrderServiceById(int id, int orderId, int serviceId, int workerId, int workload)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.UpdateOrderServiceById,
                new { id, orderId, serviceId, workerId, workload }, commandType: CommandType.StoredProcedure);
        }
    }
}