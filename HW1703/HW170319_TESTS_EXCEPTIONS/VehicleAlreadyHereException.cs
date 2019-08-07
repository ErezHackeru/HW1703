using System;
using System.Runtime.Serialization;

namespace HW170319_TESTS_EXCEPTIONS
{
    [Serializable]
    public class VehicleAlreadyHereException : Exception
    {
        public VehicleAlreadyHereException()
        {
        }

        public VehicleAlreadyHereException(string message) : base(message)
        {
        }

        public VehicleAlreadyHereException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VehicleAlreadyHereException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}