using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal.Options;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

namespace RabotyagiProject.Dal;

public class ServiceRepository : IServiceRepository
{
    public List<ServiceDto> GetAllServices()
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        return sqlConnection.Query<ServiceDto>(StoredProceduresNames.GetAllServices,
            commandType: CommandType.StoredProcedure).ToList();
    }

    public ServiceDto GetServiceById(int id)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        return sqlConnection.QueryFirst<ServiceDto>(StoredProceduresNames.GetServiceById,
            new { id }, 
            commandType: CommandType.StoredProcedure);
    }

    public void AddNewService(ServiceDto newDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.AddNewService,
            new { newDto.Type },
            commandType: CommandType.StoredProcedure);
    }

    public void UpdateServiceById(ServiceDto updatedDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.UpdateServiceById,
            new { updatedDto.Id, updatedDto.Type, updatedDto.IsDeleted }, 
            commandType: CommandType.StoredProcedure);
    }
}