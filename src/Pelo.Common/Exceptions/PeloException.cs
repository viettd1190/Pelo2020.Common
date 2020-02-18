using System;

namespace Pelo.Common.Exceptions
{
    public class PeloException : Exception
    {
        public PeloException(string message)
        {
            Msg = message;
        }

        /// <summary>
        ///     Initializes a new instance of the Exception class with a specified error message and a reference to the inner
        ///     exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        ///     The exception that is the cause of the current exception, or a null reference if no inner
        ///     exception is specified.
        /// </param>
        public PeloException(string message,
                             Exception innerException)
                : base(message, innerException)
        {
        }

        public string Msg { get; set; }
    }
}
