using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Dal;

public class ServiceRepository : IServiceRepository
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
                new { id }, 
                commandType: CommandType.StoredProcedure);
        }
    }
    public void AddNewService(ServiceDto newDto)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.AddNewService,
                new { newDto.Type },
                commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateServiceById(ServiceDto updatedDto)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.UpdateServiceById,
                new { updatedDto.Id, updatedDto.Type, updatedDto.IsDeleted }, 
                commandType: CommandType.StoredProcedure);
        }
    }
}