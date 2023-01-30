using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;

namespace RabotyagiProject.Dal;

public class BusyTimeProcedures
{
    public List<BusyTimeDto> GetAllBusyTime()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<BusyTimeDto>(Options.StoredProcedures.GetAllBusyTime,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public List<BusyTimeDto> GetAllBusyTimeByTimetableId()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<BusyTimeDto>(Options.StoredProcedures.GetAllBusyTimeByTimetableId,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public void AddNewBusyTime(TimeOnly startTime, TimeOnly endTime, int timetableId)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.AddNewBusyTime, new { startTime,endTime,timetableId }, commandType: CommandType.StoredProcedure);
        }
    }

    public void UpdateBusyTimeById(int id, TimeOnly startTime, TimeOnly endTime, int timetableId, bool isDeleted)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.UpdateBusyTimeById, new { id, startTime, endTime, timetableId, isDeleted }, commandType: CommandType.StoredProcedure);
        }
    }
}