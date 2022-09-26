using System;
using System.Runtime.Serialization;

namespace DatabaseFileExport.Exceptions
{
    /// <summary>
    /// Represents errors that occur when filling data into an object.
    /// </summary>
    [Serializable]
    public class FillException : Exception
    {
        public FillException() { }

        public FillException(string message) : base(message) { }

        public FillException(string message, Exception inner) : base(message, inner) { }

        protected FillException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }
    }
}