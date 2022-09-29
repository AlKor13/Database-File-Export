using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using DatabaseFileExport.Classes.HelpClasses;

namespace DatabaseFileExport.Classes
{
    public class DataBaseShemaManager
    {
        public static async Task<DataTable> GetDataBaseTables(SqlConnectionStringBuilder connectionString)
        {
            try
            {
                return await SQLQueryExecutor.Execute(connectionString.ConnectionString, new SqlCommand(
                    $"SELECT TABLE_NAME FROM [{connectionString.InitialCatalog}].INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'"));
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static async Task<Dictionary<string, List<string>>> GetVarBinaryTables(string connectionString)
        {
            try
            {
               
                DataTable tables = await  SQLQueryExecutor.Execute(connectionString,
                    new SqlCommand("SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE DATA_TYPE = 'varbinary'"));

                Dictionary<string, List<string>> tablesAndColumns = new Dictionary<string, List<string>>();

                foreach (DataRow data in tables.Rows)
                {
                    string columnName = data.ItemArray[0].ToString();
                    if (tablesAndColumns.Keys.Contains(columnName))
                    {
                        tablesAndColumns[columnName].Add(data.ItemArray[1].ToString());
                    }
                    else
                    {
                        tablesAndColumns.Add(columnName, 
                            new List<string>()
                            {
                                data.ItemArray[1].ToString()
                            }
                        );
                    }
                }

                return tablesAndColumns;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static async Task<DataTable> GetNotVarBinaryColumnFromTable(string connectionString, string tableName)
        {
            try
            {
                DataTable columns = await SQLQueryExecutor.Execute(connectionString, new SqlCommand(
                    $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableName}' AND DATA_TYPE != 'varbinary' "));

                return columns;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}