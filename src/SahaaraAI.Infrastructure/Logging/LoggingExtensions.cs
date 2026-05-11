using Microsoft.Extensions.Logging;

namespace SahaaraAI.Infrastructure.Logging;

public static class LoggingExtensions
{
    public static ILoggingBuilder AddSahaaraLogging(this ILoggingBuilder builder)
    {
        return builder;
    }
}
