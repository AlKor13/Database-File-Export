using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DatabaseFileExport.Classes.HelpClasses
{
    public static class SQLQueryExecutor
    {
        public static async Task<DataTable> Execute(string connectionString, SqlCommand sqlQuery)
        {
            try
            {
                SqlDataManager request = new SqlDataManager(connectionString);
                DataTable response = await request.Execute(sqlQuery);

                return response;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}