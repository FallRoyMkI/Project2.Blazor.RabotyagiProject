using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal.Options;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

namespace RabotyagiProject.Dal;

public class TimetableRepository : ITimetableRepository
{
    public List<TimetableDto> GetAllTimetable()
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        return sqlConnection.Query<TimetableDto>(StoredProceduresNames.GetAllTimetable,
            commandType: CommandType.StoredProcedure).ToList();
    }

    public List<TimetableDto> GetAllTimetableByWorkerId(int workerId)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        return sqlConnection.Query<TimetableDto>(StoredProceduresNames.GetAllTimetableByWorkerId,
            new{ workerId },
            commandType: CommandType.StoredProcedure).ToList();
    }

    public void AddNewTimetable(TimetableDto newDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.AddNewTimetable,
            new { newDto.WorkerId, newDto.WorkingDayId },
            commandType: CommandType.StoredProcedure);
    }

    public void UpdateTimetableById(TimetableDto updatedDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.UpdateTimetableById,
            new { updatedDto.Id, updatedDto.WorkerId, updatedDto.WorkingDayId, updatedDto.IsDeleted }, 
            commandType: CommandType.StoredProcedure);
    }
}