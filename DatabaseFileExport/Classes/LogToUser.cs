using System;
using System.Windows.Forms;
using DatabaseFileExport.Enums;
using DatabaseFileExport.Interfaces;

namespace DatabaseFileExport.Classes
{
    public class LogToUser : ILogger
    {
        public T Log<T>(LogLevel logLevl, string message)
        {
            DialogResult dialogResult;
            switch (logLevl)
            {
                case LogLevel.Info:
                    dialogResult = MessageBox.Show(message, "Внимание!", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information);
                    break;
                case LogLevel.Warning:
                    dialogResult = MessageBox.Show(message, "Внимание!", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning);
                    break;
                case LogLevel.Error:
                    dialogResult = MessageBox.Show(message, "Ошибка!", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error);
                    break;
                case LogLevel.Fatal:
                    dialogResult = MessageBox.Show(message, "Критическая ошибка!", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error);
                    break;
                default:
                    dialogResult = MessageBox.Show(message, "Внимание!", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information);
                    break;
            }

            return (T)Convert.ChangeType(dialogResult, typeof(T));
        }
    }
}