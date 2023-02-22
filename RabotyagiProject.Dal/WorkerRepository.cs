using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal.Options;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

namespace RabotyagiProject.Dal;

public class WorkerRepository : IWorkerRepository
{
    public List<WorkerDto> GetAllWorkers()
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open(); 
        var result = sqlConnection.Query<WorkerDto>(StoredProceduresNames.GetAllWorkers,
            commandType: CommandType.StoredProcedure).ToList();
        foreach (var worker in result)
        {
            worker.Service = GetAllWorkerServicesByWorkerId(worker.Id);
        }
        return result;
    }

    public WorkerDto GetWorkerById(int Id)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        var result = sqlConnection.QueryFirst<WorkerDto>(StoredProceduresNames.GetWorkerById,
            new { Id }, commandType: CommandType.StoredProcedure);
        result.Service = GetAllWorkerServicesByWorkerId(result.Id);
        return result;
    }

    public void AddNewWorker(WorkerDto newDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.AddNewWorker, 
            new { newDto.Name, newDto.Phone, newDto.Mail }, 
            commandType: CommandType.StoredProcedure);
    }

    public void UpdateWorkerById(WorkerDto updatedDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.UpdateWorkerById, 
            new { updatedDto.Id, updatedDto.Name, updatedDto.Phone, updatedDto.Mail, updatedDto.IsDeleted }, 
            commandType: CommandType.StoredProcedure);
    }

    public void AddNewServiceToWorker(int workerId, ServiceDto newDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.AddNewServiceToWorker, 
            new { workerId, newDto.Id, newDto.Cost }, 
            commandType: CommandType.StoredProcedure);
    }

    public void UpdateWorkerService(int workerId, ServiceDto updatedDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.UpdateWorkerService, 
            new { workerId, updatedDto.Id, updatedDto.Cost, updatedDto.IsDeleted }, 
            commandType: CommandType.StoredProcedure);
    }

    private List<ServiceDto> GetAllWorkerServicesByWorkerId(int id)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        return sqlConnection.Query<ServiceDto>(StoredProceduresNames.GetAllWorkerServicesByWorkerId, 
            new{ id }, 
            commandType: CommandType.StoredProcedure).ToList();
    }
}