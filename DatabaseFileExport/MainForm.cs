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
        private static UpdateFileModel FileModel;
        private readonly LogToUser LogToUser = new LogToUser();

        public Form1()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
        }

        private async void CheckConnectionStringButton_Click(object sender, EventArgs e)
        {
            SelectDataBaseTableComboBox.SelectedItem = null;
            SelectDataBaseTableComboBox.SelectedText = "Выбрать таблицу";

            FileModel = new UpdateFileModel();
            if (ConnectionStringTextBox.Text.Length < 5)
            {
                LogToUser.Log<DialogResult>(LogLevel.Error, "Неверный формат строки подключения!");
            }
            else
            {
                #region CheckConnectionString

                try
                {
                    FileModel.Connectionstring = new SqlConnectionStringBuilder(ConnectionStringTextBox.Text);

                    DataTable tablesNames = await GetAllTablesFromDB.Get(FileModel.Connectionstring);
                    SelectDataBaseTableComboBox.Fill(tablesNames, "TABLE_NAME");
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

                DBTableNameTextBox.Text = combobox.SelectedItem.ToString();
                FileModel.DataBaseTable = combobox.SelectedItem.ToString();

                SqlDataManager getAllColumnsNames = new SqlDataManager(FileModel.Connectionstring.ConnectionString);
                DataTable tableColumns = await getAllColumnsNames.Execute(new SqlCommand(
                    $"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{FileModel.DataBaseTable}'"));

                TableColumnComboBox.Fill(tableColumns, "COLUMN_NAME");
                TableColumn2ComboBox.Fill(tableColumns, "COLUMN_NAME");

                panel1.Visible = true;
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
                    FileModel.FilePath = getFile.FileName;

                    FileInfo fileName = new FileInfo(getFile.FileName);

                    SelectFileButton.Text = fileName.Name;
                }
            }
        }
    }
}