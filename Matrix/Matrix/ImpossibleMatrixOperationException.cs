using System;
using System.Runtime.Serialization;

namespace Matrix
{
    [Serializable]
    internal class ImpossibleMatrixOperationException : Exception
    {
        public ImpossibleMatrixOperationException()
        {
            Console.WriteLine("Pa");
        }

        public ImpossibleMatrixOperationException(string message) : base(message)
        {
        }

        public ImpossibleMatrixOperationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ImpossibleMatrixOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}