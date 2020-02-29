using System;
using System.Runtime.Serialization;

namespace Places
{
    [Serializable]
    public class DiamondNotAddedException : Exception
    {
        public DiamondNotAddedException()
        {
        }

        public DiamondNotAddedException(string message) : base(message)
        {
        }

        public DiamondNotAddedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DiamondNotAddedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}