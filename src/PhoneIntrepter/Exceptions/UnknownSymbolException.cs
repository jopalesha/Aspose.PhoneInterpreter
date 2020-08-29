using System;

namespace Aspose.PhoneInterpreter.Exceptions
{
    [Serializable]
    public class UnknownSymbolException : PhoneInterpreterException
    {
        public UnknownSymbolException()
        {
        }

        public UnknownSymbolException(string message) : base(message)
        {
        }

        public UnknownSymbolException(string message, Exception inner) : base(message, inner)
        {
        }
        
        protected UnknownSymbolException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}