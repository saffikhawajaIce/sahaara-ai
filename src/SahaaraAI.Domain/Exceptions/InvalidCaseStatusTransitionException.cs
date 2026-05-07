namespace SahaaraAI.Domain.Exceptions
{
    /// <summary>
    /// Exception thrown when an invalid case status transition is attempted.
    /// </summary>
    public class InvalidCaseStatusTransitionException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidCaseStatusTransitionException"/> class.
        /// </summary>
        public InvalidCaseStatusTransitionException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidCaseStatusTransitionException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public InvalidCaseStatusTransitionException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidCaseStatusTransitionException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public InvalidCaseStatusTransitionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
