using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using RabotyagiProject.Dal.Models;

namespace RabotyagiProject.Dal
{
    public class OrderServiceWorkerRepository
    {
        public bool DeleteOrderServiceWorkerById(int id)
        {
            {
                using (var sqlConnection = new SqlConnection(Options.Constants.ConnectionString))
                {
                    sqlConnection.Open();
                    return sqlConnection.Execute(Options.StoredProceduresNames.DeleteOrderServiceWorkerById,
                    new { id },
                    commandType: CommandType.StoredProcedure) >0;
                }
            }

        }
    }
}
