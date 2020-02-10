using System;

namespace Pelo.Common.Exceptions
{
    public class PeloException : Exception
    {
        public PeloException(string message)
        {
            Msg = message;
        }

        public string Msg { get; set; }
    }
}
