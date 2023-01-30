using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;

namespace RabotyagiProject.Dal;

public class ServiceProcedure
{
    public List<ServiceDto> GetAllServices()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<ServiceDto>(Options.StoredProcedures.GetAllServices,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public ServiceDto GetServiceById(int id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.QueryFirst<ServiceDto>(Options.StoredProcedures.GetServiceById,
                new { id }, commandType: CommandType.StoredProcedure);
        }
    }
    public void AddNewService(string type)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.AddNewService,
                new { type}, commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateServiceById(int id, string type, bool isDeleted)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.UpdateServiceById,
                new { id, type, isDeleted }, commandType: CommandType.StoredProcedure);
        }
    }
}