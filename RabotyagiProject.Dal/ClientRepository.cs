using System.Data;
using RabotyagiProject.Dal.Models;
using Microsoft.Data.SqlClient;
using Dapper;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Dal;

public class ClientRepository : IClientRepository
{
    public List<ClientDto> GetAllClients()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<ClientDto>(Options.StoredProceduresNames.GetAllClients,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }

    public ClientDto GetClientById(int Id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.QueryFirst<ClientDto>(Options.StoredProceduresNames.GetClientById,
            new { Id }, 
            commandType: CommandType.StoredProcedure);
        }
    }

    public void AddNewClient(ClientDto newDto)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.AddNewClient,
                new { newDto.Name,newDto.Phone, newDto.Mail }, 
                commandType: CommandType.StoredProcedure);
        }
    }

    public void UpdateClientById(ClientDto updatedDto)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.UpdateClientById, 
                new { updatedDto.Id, updatedDto.Name, updatedDto.Phone, updatedDto.Mail, updatedDto.IsDeleted }, 
                commandType: CommandType.StoredProcedure);
        }
    }
}