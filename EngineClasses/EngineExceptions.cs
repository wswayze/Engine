using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace EngineClasses
{
    class EngineExceptions
    {
    }

    public class BadParameterException : Exception, ISerializable
    {
        public BadParameterException()
        {
            // Add implementation.
        }
        public BadParameterException(string message)
        {
            // Add implementation.
        }
        public BadParameterException(string message, Exception inner)
        {
            // Add implementation.
        }

        // This constructor is needed for serialization.
        protected BadParameterException(SerializationInfo info, StreamingContext context)
        {
            // Add implementation.
        }
    }
}
