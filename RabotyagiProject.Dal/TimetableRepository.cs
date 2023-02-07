using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Dal;

public class TimetableRepository : ITimetableRepository
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
                new{ workerId },
                commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public void AddNewTimetable(TimetableDto newDto)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.AddNewTimetable,
                new { newDto.WorkerId, newDto.WorkingDayId },
                commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateTimetableById(TimetableDto updatedDto)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.UpdateTimetableById,
                new { updatedDto.Id, updatedDto.WorkerId, updatedDto.WorkingDayId, updatedDto.IsDeleted }, 
                commandType: CommandType.StoredProcedure);
        }
    }

    
}