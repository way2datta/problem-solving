using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ProblemSolving.QueueImplementation
{
    public class QueueException : Exception
    {
        public QueueException()
        {
        }

        public QueueException(string message) : base(message)
        {
        }

        public QueueException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected QueueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
