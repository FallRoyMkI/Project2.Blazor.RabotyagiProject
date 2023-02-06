using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;

namespace RabotyagiProject.Dal;

public class BusyTimeRepository
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
    public void AddNewBusyTime(TimeSpan startTime, TimeSpan endTime, int timetableId)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.AddNewBusyTime, new { startTime,endTime,timetableId }, commandType: CommandType.StoredProcedure);
        }
    }

    public void UpdateBusyTimeById(int id, TimeSpan startTime, TimeSpan endTime, int timetableId, bool isDeleted)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.UpdateBusyTimeById, new { id, startTime, endTime, timetableId, isDeleted }, commandType: CommandType.StoredProcedure);
        }
    }
}