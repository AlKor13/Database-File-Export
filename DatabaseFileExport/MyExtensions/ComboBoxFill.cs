using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DatabaseFileExport.Exceptions;

namespace DatabaseFileExport.MyExtensions
{
    internal static class ComboBoxFill
    {
        /// <summary>
        ///  Fills the ComboBox with data
        /// </summary>
        /// <param name="comboBox">ComboBox to fill</param>
        /// <param name="data">Data to add to combobox</param>
        /// <exception cref="FillException">The exception that is thrown when it is not possible to add data to the ComboBox</exception>
        public static void Fill(this ComboBox comboBox, List<string> data)
        {
            try
            {
                if (data.Count == 0)
                    throw new FillException("Список файлов для вставки пуст");
                comboBox.DataSource = data;
            }
            catch (Exception ex)
            {
                throw new FillException($"Ошибка добавления данных в comboBox \n{ex.Message}");
            }
        }

        /// <summary>
        ///     Fills the ComboBox with data
        /// </summary>
        /// <param name="comboBox">ComboBox to fill</param>
        /// <param name="data">Data to add to combobox</param>
        /// <param name="displayMember">The name of the DataTable column by which data will be added to the combobox</param>
        /// <exception cref="FillException">The exception that is thrown when it is not possible to add data to the ComboBox</exception>
        public static void Fill(this ComboBox comboBox, DataTable data, string displayMember)
        {
            try
            {
                if (data.Rows.Count == 0)
                {
                    throw new FillException("Список файлов для вставки пуст");
                }

                comboBox.Items.Clear();
                comboBox.SelectedItem = null;

                foreach (DataRow dr in data.Rows)
                    comboBox.Items.Add(dr[displayMember].ToString());
            }
            catch (Exception ex)
            {
                throw new FillException($"Ошибка добавления данных в comboBox \n{ex.Message}");
            }
        }
    }
}