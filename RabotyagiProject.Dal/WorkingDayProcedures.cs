using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;

namespace RabotyagiProject.Dal;

public class WorkingDayProcedures
{
    public List<WorkingDayDto> GetAllWorkingDays()
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            return sqlConnection.Query<WorkingDayDto>(Options.StoredProcedures.GetAllWorkingDays,
                commandType: CommandType.StoredProcedure).ToList();
        }
    }
    public void AddNewWorkingDay(DateOnly date)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.AddNewWorkingDay, new { date }, commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateWorkingDayById(int id, DateOnly date)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProcedures.UpdateWorkingDayById, new { id, date }, commandType: CommandType.StoredProcedure);
        }
    }
}