using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;

namespace RabotyagiProject.Dal;

public class ServiceRepository
{
    public List<ServiceDto> GetAllServices()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<ServiceDto>(Options.StoredProceduresNames.GetAllServices,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public ServiceDto GetServiceById(int id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.QueryFirst<ServiceDto>(Options.StoredProceduresNames.GetServiceById,
                new { id }, commandType: CommandType.StoredProcedure);
        }
    }
    public void AddNewService(string type)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.AddNewService,
                new { type}, commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateServiceById(int id, string type, bool isDeleted)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.UpdateServiceById,
                new { id, type, isDeleted }, commandType: CommandType.StoredProcedure);
        }
    }
}