using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal.Options;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

namespace RabotyagiProject.Dal;

public class ClientRepository : IClientRepository
{
    public List<ClientDto> GetAllClients()
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        return sqlConnection.Query<ClientDto>(StoredProceduresNames.GetAllClients,
            commandType: CommandType.StoredProcedure).ToList();
    }

    public ClientDto GetClientById(int Id)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        return sqlConnection.QueryFirst<ClientDto>(StoredProceduresNames.GetClientById,
            new { Id }, 
            commandType: CommandType.StoredProcedure);
    }

    public void AddNewClient(ClientDto newDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.AddNewClient,
            new { newDto.Name, newDto.Phone, newDto.Mail }, 
            commandType: CommandType.StoredProcedure);
    }

    public void UpdateClientById(ClientDto updatedDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.UpdateClientById, 
            new { updatedDto.Id, updatedDto.Name, updatedDto.Phone, updatedDto.Mail, updatedDto.IsDeleted }, 
            commandType: CommandType.StoredProcedure);
    }
}