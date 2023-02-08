using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Dal;

public class BusyTimeRepository : IBusyTimeRepository
{
    public List<BusyTimeDto> GetAllBusyTime()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<BusyTimeDto>(Options.StoredProceduresNames.GetAllBusyTime,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public List<BusyTimeDto> GetAllBusyTimeByTimetableId(int timetableId)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<BusyTimeDto>(Options.StoredProceduresNames.GetAllBusyTimeByTimetableId,
                new{ timetableId },
                commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public void AddNewBusyTime(BusyTimeDto newDto)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.AddNewBusyTime, 
                new { newDto.StartTime, newDto.EndTime, newDto.TimetableId }, 
                commandType: CommandType.StoredProcedure);
        }
    }

    public void UpdateBusyTimeById(BusyTimeDto updatedDto)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.UpdateBusyTimeById, 
                new { updatedDto.Id, updatedDto.StartTime, updatedDto.EndTime, updatedDto.TimetableId, updatedDto.IsDeleted }, 
                commandType: CommandType.StoredProcedure);
        }
    }
}