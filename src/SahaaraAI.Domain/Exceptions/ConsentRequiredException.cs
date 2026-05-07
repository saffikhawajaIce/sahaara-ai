namespace SahaaraAI.Domain.Exceptions;

/// <summary>
/// Exception thrown when consent is required but not provided.
/// </summary>
public class ConsentRequiredException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConsentRequiredException"/> class.
    /// </summary>
    public ConsentRequiredException() : base("Consent is required.")
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConsentRequiredException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public ConsentRequiredException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConsentRequiredException"/> class with a specified error message and inner exception.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">The exception that is the cause of the current exception.</param>
    public ConsentRequiredException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
