using System;
using System.Runtime.Serialization;

namespace Autok_Szervíz
{
    [Serializable]
    internal class ABkivetel : Exception
    {
        public ABkivetel()
        {
        }

        public ABkivetel(string message) : base(message)
        {
        }

        public ABkivetel(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ABkivetel(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}