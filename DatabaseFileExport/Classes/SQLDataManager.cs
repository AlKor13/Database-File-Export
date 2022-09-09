using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DatabaseFileExport.Classes
{
    /// <summary>
    /// Provides the ability to perform database-related operations
    /// </summary>
    internal class SqlDataManager
    {
        private readonly string ConnectionString;

        public SqlDataManager(string connectionString)
        {
            ConnectionString = connectionString;
        }
        
        /// <summary>
        /// Executes a sql query to DataBase
        /// </summary>
        /// <param name="command">SQL command class instance</param>
        /// <returns>Completed DataTable with data based on SQL query</returns>
        /// <exception cref="SqlException">The exception that is thrown when SQL Server returns a warning or error. This class is not inherited.</exception>
        /// <exception cref="Exception">Represents errors that occur during application execution.</exception>
        public async Task<DataTable> Execute(SqlCommand command)
        {
            try
            {
                DataTable tableToFill = new DataTable();

                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    await conn.OpenAsync();
                    using (command)
                    {
                        command.Connection = conn;

                        using (SqlDataReader dataReader = await command.ExecuteReaderAsync())
                        {
                            if (dataReader.HasRows) 
                                tableToFill.Load(dataReader);
                        }
                    }
                }

                return tableToFill;
            }
            catch (SqlException sqlEx)
            {
                throw sqlEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}