using System;

namespace Aspose.PhoneInterpreter.Exceptions
{
    [Serializable]
    public class PhoneInterpreterException : Exception
    {
        public PhoneInterpreterException()
        {
        }

        public PhoneInterpreterException(string message) : base(message)
        {
        }

        public PhoneInterpreterException(string message, Exception inner) : base(message, inner)
        {
        }

        protected PhoneInterpreterException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
        }
    }
}