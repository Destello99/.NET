using System.Runtime.Serialization;

namespace EventHandling
{
    [Serializable]
    internal class InvalidInputException : ApplicationException
    {
        public InvalidInputException()
        {
        }

        public InvalidInputException(string? message) : base(message)
        {
        }

        public InvalidInputException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidInputException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}