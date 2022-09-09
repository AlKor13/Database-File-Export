using DatabaseFileExport.Enums;

namespace DatabaseFileExport.Interfaces
{
    public interface ILogger
    {
        T Log<T>(LogLevel logLevl, string message);
    }
}