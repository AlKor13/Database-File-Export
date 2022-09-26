using System;
using System.IO;
using System.Windows.Forms;
using DatabaseFileExport.Exceptions;

namespace DatabaseFileExport.Classes.HelpClasses
{
    public static class FileWorker
    {
        /// <summary>
        /// Get image byte array.
        /// </summary>
        /// <param name="imagePath">Path to image</param>
        /// <returns></returns>
        /// <exception cref="FileWorkerException"></exception>
        public static byte[] GetFileBytes(string imagePath)
        {
            try
            {
                byte[] imageData = File.ReadAllBytes(imagePath);
                return imageData;
            }
            catch (Exception e)
            {
                throw new FileWorkerException(e.Message);
            }
        }

        /// <summary>
        /// Allows to select a file, located on the computer.
        /// </summary>
        /// <param name="fileDialog"></param>
        /// <returns>Boolean flag if file selected</returns>
        /// <exception cref="FileWorkerException"></exception>
        public static bool SelectFileFromPC(OpenFileDialog fileDialog)
        {
            try
            {   
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                throw new  FileWorkerException(e.Message);
            }
        }
    }
}