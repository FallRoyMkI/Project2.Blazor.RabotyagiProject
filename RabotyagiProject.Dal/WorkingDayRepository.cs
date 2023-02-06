using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;
using System.Data;
using Dapper;
using RabotyagiProject.Dal.Interface;

namespace RabotyagiProject.Dal;

public class WorkingDayRepository : IWorkingDayAdder, IWorkingDayGetter, IWorkingDayUpdater
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
    public void AddNewWorkingDay(DateTime date)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.AddNewWorkingDay, new { date }, commandType: CommandType.StoredProcedure);
        }
    }
    public void UpdateWorkingDayById(int id, DateTime date)
    {
        using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
        {
            sqlConnection.Open();
            sqlConnection.Execute(Options.StoredProceduresNames.UpdateWorkingDayById, new { id, date }, commandType: CommandType.StoredProcedure);
        }
    }
}