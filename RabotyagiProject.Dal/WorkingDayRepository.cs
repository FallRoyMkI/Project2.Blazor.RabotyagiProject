using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Dal;

public class WorkingDayRepository : IWorkingDayRepository
{
    public List<WorkingDayDto> GetAllWorkingDays()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<WorkingDayDto>(Options.StoredProceduresNames.GetAllWorkingDays,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public WorkingDayDto GetWorkingDayById(int id)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.QueryFirst<WorkingDayDto>(Options.StoredProceduresNames.GetWorkingDayById,
                new { id },
                commandType: CommandType.StoredProcedure);
        }
    }
    public void AddNewWorkingDay(DateTime date)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.AddNewWorkingDay, new { date }, commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateWorkingDayById(WorkingDayDto updatedDto)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.UpdateWorkingDayById, new { updatedDto.Id, updatedDto.Date }, commandType: CommandType.StoredProcedure);
        }
    }
}