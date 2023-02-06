using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Dal;

public class TimetableRepository : ITimetableGetter, ITimetableAdder, ITimetableUpdater
{
    public List<TimetableDto> GetAllTimetable()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<TimetableDto>(Options.StoredProceduresNames.GetAllTimetable,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }

    public List<TimetableDto> GetAllTimetableByWorkerId(int workerId)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<TimetableDto>(Options.StoredProceduresNames.GetAllTimetableByWorkerId,
                new{ workerId },commandType: CommandType.StoredProcedure).ToList();
        }
    }

    public void UpdateTimetableById(int id,int workerId, int workingDayId, bool isDeleted)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.UpdateTimetableById,
                new { id, workerId, workingDayId,isDeleted }, commandType: CommandType.StoredProcedure);
        }
    }

    public void AddNewTimetable(int workerId, int workingDayId)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.AddNewTimetable,
                new { workerId, workingDayId}, commandType: CommandType.StoredProcedure);
        }
    }
}