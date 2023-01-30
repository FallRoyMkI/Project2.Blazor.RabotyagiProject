using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;
using System.Numerics;

namespace RabotyagiProject.Dal;

public class WorkerProcedures
{
    public List<WorkerDto> GetAllWorkers()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<WorkerDto>(Options.StoredProcedures.GetAllWorkers,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public WorkerDto GetWorkerById(int Id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.QueryFirst<WorkerDto>(Options.StoredProcedures.GetWorkerById,
                new { Id }, commandType: CommandType.StoredProcedure);
        }
    }
    public void AddNewWorker(string name, string phone, string mail)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.AddNewWorker, new { name, phone, mail }, commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateWorkerById(int id, string name, string phone, string mail, bool isDeleted)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.UpdateWorkerById, new { id, name, phone, mail, isDeleted }, commandType: CommandType.StoredProcedure);
        }
    }
    public void AddNewServiceToWorker(int workerId, int serviceId, int cost)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.AddNewServiceToWorker, new { workerId, serviceId, cost }, commandType: CommandType.StoredProcedure);
        }
    }
    public List<ServiceDto> GetAllWorkerServicesByWorkerId(int id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<ServiceDto>(Options.StoredProcedures.GetAllWorkerServicesByWorkerId,
                new{id}, commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public void UpdateWorkerService(int workerId, int serviceId, int cost, bool isDeleted)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.UpdateWorkerService, new { workerId, serviceId, cost, isDeleted}, commandType: CommandType.StoredProcedure);
        }
    }

}