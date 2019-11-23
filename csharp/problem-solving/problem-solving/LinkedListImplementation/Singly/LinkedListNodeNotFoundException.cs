using System;
using System.Runtime.Serialization;

namespace ProblemSolving.LinkedListImplementation.Singly
{
    [Serializable]
    public class LinkedListNodeNotFoundException : Exception
    {
        public LinkedListNodeNotFoundException()
        {
        }

        public LinkedListNodeNotFoundException(string message) : base(message)
        {
        }

        public LinkedListNodeNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LinkedListNodeNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}