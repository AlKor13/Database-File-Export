using System;
using System.Runtime.Serialization;

namespace DatabaseFileExport.Exceptions
{
    /// <summary>
    /// Represents errors that occur when working with files.
    /// </summary>
    [Serializable]
    public class FileWorkerException : Exception
    {
        public FileWorkerException() { }

        public FileWorkerException(string message) : base(message) { }

        public FileWorkerException(string message, Exception inner) : base(message, inner) { }

        protected FileWorkerException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}