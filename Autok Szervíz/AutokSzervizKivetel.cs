using System;
using System.Runtime.Serialization;

namespace Autok_Szervíz
{
    [Serializable]
    internal class AutokSzervizKivetel : Exception
    {
        public AutokSzervizKivetel()
        {
        }

        public AutokSzervizKivetel(string message) : base(message)
        {
        }

        public AutokSzervizKivetel(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AutokSzervizKivetel(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}