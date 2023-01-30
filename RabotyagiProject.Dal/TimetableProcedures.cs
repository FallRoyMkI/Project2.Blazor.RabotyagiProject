using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;

namespace RabotyagiProject.Dal;

public class TimetableProcedures
{
    public List<TimetableDto> GetAllTimetable()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<TimetableDto>(Options.StoredProcedures.GetAllTimetable,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }

    public List<TimetableDto> GetAllTimetableByWorkerId(int id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<TimetableDto>(Options.StoredProcedures.GetAllTimetableByWorkerId,
                new{id},commandType: CommandType.StoredProcedure).ToList();
        }
    }

    public void UpdateTimetableById(int id,int workerId, int workingDayId, bool isDeleted)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.UpdateTimetableById,
                new { id, workerId, workingDayId,isDeleted }, commandType: CommandType.StoredProcedure);
        }
    }

    public void AddNewTimetable(int workerId, int workingDayId)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.AddNewTimetable,
                new { workerId, workingDayId}, commandType: CommandType.StoredProcedure);
        }
    }
}