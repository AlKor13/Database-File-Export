using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DatabaseFileExport.Classes
{
    public class GetAllTablesFromDB
    {
        public static async Task<DataTable> Get(SqlConnectionStringBuilder connectionString)
        {
            try
            {
                SqlDataManager getTabels = new SqlDataManager(connectionString.ConnectionString);
                DataTable result = await getTabels.Execute(new SqlCommand(
                    $"SELECT TABLE_NAME FROM [{connectionString.InitialCatalog}].INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'"));
                
                return result;
            }
            catch (SqlException sqlEx)
            {
                throw;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}