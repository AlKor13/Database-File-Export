using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using DatabaseFileExport.Classes;
using DatabaseFileExport.Enums;
using DatabaseFileExport.Exceptions;
using DatabaseFileExport.Models;
using DatabaseFileExport.MyExtensions;

namespace DatabaseFileExport
{
    public partial class Form1 : Form
    {
        private static ExportFileModel ExportFileModel;
        private readonly LogToUser LogToUser = new LogToUser();

        public Form1()
        {
            InitializeComponent();
        }

        private async void CheckConnectionStringButton_Click(object sender, EventArgs e)
        {
            SelectDataBaseTableComboBox.SelectedItem = null;
            SelectDataBaseTableComboBox.SelectedText = "Выбрать таблицу";

            ExportFileModel = new ExportFileModel();
            if (ConnectionStringTextBox.Text.Length < 5)
            {
                LogToUser.Log<DialogResult>(LogLevel.Error, "Неверный формат строки подключения!");
            }
            else
            {
                #region CheckConnectionString

                try
                {
                    ExportFileModel.Connectionstring = new SqlConnectionStringBuilder(ConnectionStringTextBox.Text);

                    DataTable tablesNames = await GetAllTablesFromDB.Get(ExportFileModel.Connectionstring);
                    SelectDataBaseTableComboBox.Fill(tablesNames, "TABLE_NAME");
                    DBTablePanel.Visible = true;
                }
                catch (KeyNotFoundException keyEx)
                {
                    LogToUser.Log<DialogResult>(LogLevel.Error,
                        $"Ошибка преобразования строки подключения!\n{keyEx.Message}");
                }
                catch (FormatException formatEx)
                {
                    LogToUser.Log<DialogResult>(LogLevel.Error,
                        $"Неверный формат строки подключения! \n{formatEx.Message}");
                }
                catch (ArgumentException argumentEx)
                {
                    LogToUser.Log<DialogResult>(LogLevel.Error,
                        $"Неверный аргумент строки подключения! \n{argumentEx.Message}");
                }
                catch (SqlException sqlEx)
                {
                    LogToUser.Log<DialogResult>(LogLevel.Fatal, sqlEx.Message);
                }
                catch (FillException fillException)
                {
                    LogToUser.Log<DialogResult>(LogLevel.Fatal, fillException.Message);
                }
                catch (Exception exception)
                {
                    LogToUser.Log<DialogResult>(LogLevel.Error,
                        $"Ошибка! \n{exception.Message}");
                }
                
                #endregion
            }
        }

        private async void SelectDataBaseTableComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (!(sender is ComboBox combobox)) return;

                SQLQueryPanel.Visible = false;
                InsertButton.Visible = false;
                
                DBTableNameTextBox.Text = combobox.SelectedItem.ToString();
                ExportFileModel.DataBaseTable = combobox.SelectedItem.ToString();

                SqlDataManager getAllColumnsNames = new SqlDataManager(ExportFileModel.Connectionstring.ConnectionString);
                DataTable tableColumns = await getAllColumnsNames.Execute(new SqlCommand(
                    $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{ExportFileModel.DataBaseTable}'"));

                DataTable varbinaryColumn = await getAllColumnsNames.Execute(new SqlCommand(
                    $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{ExportFileModel.DataBaseTable}' AND DATA_TYPE = 'varbinary'"));

                if (varbinaryColumn.Rows.Count == 0)
                {
                    LogToUser.Log<DialogResult>(LogLevel.Error,
                        $"В таблице {ExportFileModel.DataBaseTable} нет столбца с типом varbinary");
                }
                else
                {
                    ColumnToUpdateComboBox.Fill(varbinaryColumn, "COLUMN_NAME");
                    FilterTableComboBox.Fill(tableColumns, "COLUMN_NAME");
                    SQLQueryPanel.Visible = true;
                    InsertButton.Visible = true;
                }
            }
            catch (SqlException sqlEx)
            {
                LogToUser.Log<DialogResult>(LogLevel.Fatal, sqlEx.Message);
            }
            catch (FillException fillException)
            {
                LogToUser.Log<DialogResult>(LogLevel.Fatal, fillException.Message);
            }
            catch (Exception exception)
            {
                LogToUser.Log<DialogResult>(LogLevel.Fatal, exception.Message);
            }
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog getFile = new OpenFileDialog())
            {
                getFile.Title = "Выбирите файл который нужно вставить в базу данных";
                getFile.Multiselect = false;

                if (getFile.ShowDialog() == DialogResult.OK)
                {
                    ExportFileModel.FilePath = getFile.FileName;

                    FileInfo fileName = new FileInfo(getFile.FileName);

                    SelectFileButton.Text = fileName.Name;
                }
            }
        }
        
        private async void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                string columnToUpdate = ColumnToUpdateComboBox.SelectedItem.ToString();
                string filterTableComboBox = FilterTableComboBox.SelectedItem.ToString();
                string filterText = FilterTextBox.Text;

                string updateFileSql =
                    $"UPDATE {ExportFileModel.DataBaseTable} SET [{columnToUpdate}] = @IM WHERE [{filterTableComboBox}] = N'{filterText}'";

                SqlCommand updateFileCommand = new SqlCommand(updateFileSql);
                byte[] imageData = File.ReadAllBytes(ExportFileModel.FilePath);
                updateFileCommand.Parameters.AddWithValue("@IM", imageData);

                SqlDataManager updateDbTable = new SqlDataManager(ExportFileModel.Connectionstring.ConnectionString);
                await updateDbTable.Execute(updateFileCommand);

                LogToUser.Log<DialogResult>(LogLevel.Info, "Готово");
            }
            catch (SqlException sqlEx)
            {
                LogToUser.Log<DialogResult>(LogLevel.Fatal, $"Ошибка выполнения SQL запроса \n\n{sqlEx.Message}");
            }
            catch (Exception ex)
            {
                LogToUser.Log<DialogResult>(LogLevel.Fatal, $"Ошибка \n\n {ex.Message}");
            }
        }
    }
}