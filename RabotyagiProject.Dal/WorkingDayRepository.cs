using RabotyagiProject.Dal.Interface;
using RabotyagiProject.Dal.Models;
using RabotyagiProject.Dal.Options;
using Microsoft.Data.SqlClient;
using System.Data;
using Dapper;

namespace RabotyagiProject.Dal;

public class WorkingDayRepository : IWorkingDayRepository
{
    public List<WorkingDayDto> GetAllWorkingDays()
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        return sqlConnection.Query<WorkingDayDto>(StoredProceduresNames.GetAllWorkingDays,
            commandType: CommandType.StoredProcedure).ToList();
    }

    public WorkingDayDto GetWorkingDayById(int id)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        return sqlConnection.QueryFirst<WorkingDayDto>(StoredProceduresNames.GetWorkingDayById,
            new { id },
            commandType: CommandType.StoredProcedure);
    }

    public void AddNewWorkingDay(DateTime date)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.AddNewWorkingDay, 
            new { date }, 
            commandType: CommandType.StoredProcedure);
    }

    public void UpdateWorkingDayById(WorkingDayDto updatedDto)
    {
        using var sqlConnection = new SqlConnection(Constants.ConnectionString);
        sqlConnection.Open();
        sqlConnection.Execute(StoredProceduresNames.UpdateWorkingDayById,
            new { updatedDto.Id, updatedDto.Date },
            commandType: CommandType.StoredProcedure);
    }
}