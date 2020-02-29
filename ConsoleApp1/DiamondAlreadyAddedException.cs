using System;
using System.Runtime.Serialization;

namespace Places
{
    [Serializable]
    public class DiamondAlreadyAddedException : Exception
    {
        public DiamondAlreadyAddedException()
        {
        }

        public DiamondAlreadyAddedException(string message) : base(message)
        {
        }

        public DiamondAlreadyAddedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DiamondAlreadyAddedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}