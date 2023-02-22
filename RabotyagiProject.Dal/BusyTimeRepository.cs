using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal.Options;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

namespace RabotyagiProject.Dal;

public class BusyTimeRepository : IBusyTimeRepository
{
    public List<BusyTimeDto> GetAllBusyTime()
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        return sqlConnection.Query<BusyTimeDto>(StoredProceduresNames.GetAllBusyTime,
            commandType: CommandType.StoredProcedure).ToList();
    }

    public List<BusyTimeDto> GetAllBusyTimeByTimetableId(int timetableId)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        return sqlConnection.Query<BusyTimeDto>(StoredProceduresNames.GetAllBusyTimeByTimetableId,
            new{ timetableId },
            commandType: CommandType.StoredProcedure).ToList();
    }

    public BusyTimeDto GetBusyTimeById(int id)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        return sqlConnection.QueryFirst<BusyTimeDto>(StoredProceduresNames.GetBusyTimeById,
            new { id },
            commandType: CommandType.StoredProcedure);
    }

    public void AddNewBusyTime(BusyTimeDto newDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.AddNewBusyTime, 
            new { newDto.StartTime, newDto.EndTime, newDto.TimetableId }, 
            commandType: CommandType.StoredProcedure);
    }

    public void UpdateBusyTimeById(BusyTimeDto updatedDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.UpdateBusyTimeById, 
            new { updatedDto.Id, updatedDto.StartTime, updatedDto.EndTime, updatedDto.TimetableId, updatedDto.IsDeleted }, 
            commandType: CommandType.StoredProcedure);
    }
}