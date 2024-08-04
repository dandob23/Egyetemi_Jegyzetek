using System;
using System.Runtime.Serialization;

namespace UnitTests
{
    [Serializable]
    internal class DateOfBirthLateException : Exception
    {
        public DateOfBirthLateException()
        {
        }

        public DateOfBirthLateException(string message) : base(message)
        {
        }

        public DateOfBirthLateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DateOfBirthLateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}