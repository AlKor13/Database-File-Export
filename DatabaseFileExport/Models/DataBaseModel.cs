using System.Data.SqlClient;

namespace DatabaseFileExport.Models
{
    public class UpdateFileModel
    {
        public SqlConnectionStringBuilder Connectionstring { get; set; }
        public string DataBaseTable { get; set; }
        public string FilePath { get; set; }
    }
}