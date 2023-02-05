using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;
using System.Numerics;

namespace RabotyagiProject.Dal;

public class WorkerRepository
{
    public List<WorkerDto> GetAllWorkers()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        { 
            sqlConnection.Open(); 
            var result = sqlConnection.Query<WorkerDto>(Options.StoredProceduresNames.GetAllWorkers,
                commandType: CommandType.StoredProcedure).ToList();
           foreach (var worker in result)
           {
               worker.Service = GetAllWorkerServicesByWorkerId(worker.Id);
           }
            return result;
        }
    }
    public WorkerDto GetWorkerById(int Id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            var result = sqlConnection.QueryFirst<WorkerDto>(Options.StoredProceduresNames.GetWorkerById,
                new { Id }, commandType: CommandType.StoredProcedure);
            result.Service = GetAllWorkerServicesByWorkerId(result.Id);
            return result;
        }
    }
    public void AddNewWorker(string name, string phone, string mail)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.AddNewWorker, new { name, phone, mail }, commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateWorkerById(int id, string name, string phone, string mail, bool isDeleted)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.UpdateWorkerById, new { id, name, phone, mail, isDeleted }, commandType: CommandType.StoredProcedure);
        }
    }
    public void AddNewServiceToWorker(int workerId, int serviceId, int cost)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.AddNewServiceToWorker, new { workerId, serviceId, cost }, commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateWorkerService(int workerId, int serviceId, int cost, bool isDeleted)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.UpdateWorkerService, new { workerId, serviceId, cost, isDeleted }, commandType: CommandType.StoredProcedure);
        }
    }
    private List<ServiceDto> GetAllWorkerServicesByWorkerId(int id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<ServiceDto>(Options.StoredProceduresNames.GetAllWorkerServicesByWorkerId, 
                new{id}, commandType: CommandType.StoredProcedure).ToList();
            
        }
    }
    
}