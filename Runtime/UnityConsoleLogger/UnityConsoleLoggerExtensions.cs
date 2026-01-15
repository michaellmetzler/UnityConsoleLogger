// Based on dotnet/runtime source code:
// https://github.com/dotnet/runtime/blob/7b2de1e5ed6368c536ee646346e6fd81939e6fe6/src/libraries/Microsoft.Extensions.Logging.Abstractions/src/LoggerExtensions.cs

#nullable enable

using System;

using UnityEngine;
using Object = UnityEngine.Object;

namespace Microsoft.Extensions.Logging
{
    /// <summary>
    /// ILogger extension methods for common scenarios.
    /// </summary>
    public static class UnityConsoleLoggerExtensions
    {
        private static readonly Func<FormattedLogValues, Exception?, string> _messageFormatter = MessageFormatter;

        //------------------------------------------DEBUG------------------------------------------//

        /// <summary>
        /// Formats and writes a debug log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogDebug(0, exception, context, "Error while processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogDebug(this ILogger logger, EventId eventId, Exception? exception, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Debug, eventId, exception, context, message, args);
        }

        /// <summary>
        /// Formats and writes a debug log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogDebug(0, context, "Processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogDebug(this ILogger logger, EventId eventId, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Debug, eventId, context, message, args);
        }

        /// <summary>
        /// Formats and writes a debug log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogDebug(exception, context, "Error while processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogDebug(this ILogger logger, Exception? exception, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Debug, exception, context, message, args);
        }

        /// <summary>
        /// Formats and writes a debug log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogDebug(context, "Processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogDebug(this ILogger logger, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Debug, context, message, args);
        }

         //------------------------------------------TRACE------------------------------------------//

        /// <summary>
        /// Formats and writes a trace log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogTrace(0, exception, context, "Error while processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogTrace(this ILogger logger, EventId eventId, Exception? exception, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Trace, eventId, exception, context, message, args);
        }
        /// <summary>
        /// Formats and writes a trace log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogTrace(0, context, "Processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogTrace(this ILogger logger, EventId eventId, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Trace, eventId, context, message, args);
        }

        /// <summary>
        /// Formats and writes a trace log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogTrace(exception, context, "Error while processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogTrace(this ILogger logger, Exception? exception, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Trace, exception, context, message, args);
        }

        /// <summary>
        /// Formats and writes a trace log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogTrace(context, "Processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogTrace(this ILogger logger, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Trace, context, message, args);
        }

        //------------------------------------------INFORMATION------------------------------------------//

        /// <summary>
        /// Formats and writes an informational log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogInformation(0, exception, context, "Error while processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogInformation(this ILogger logger, EventId eventId, Exception? exception, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Information, eventId, exception, context, message, args);
        }

        /// <summary>
        /// Formats and writes an informational log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogInformation(0, context, "Processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogInformation(this ILogger logger, EventId eventId, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Information, eventId, context, message, args);
        }

        /// <summary>
        /// Formats and writes an informational log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogInformation(exception, context, "Error while processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogInformation(this ILogger logger, Exception? exception, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Information, exception, context, message, args);
        }

        /// <summary>
        /// Formats and writes an informational log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogInformation(context, "Processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogInformation(this ILogger logger, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Information, context, message, args);
        }

        //------------------------------------------WARNING------------------------------------------//

        /// <summary>
        /// Formats and writes a warning log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogWarning(0, exception, context, "Error while processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogWarning(this ILogger logger, EventId eventId, Exception? exception, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Warning, eventId, exception, context, message, args);
        }

        /// <summary>
        /// Formats and writes a warning log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogWarning(0, context, "Processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogWarning(this ILogger logger, EventId eventId, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Warning, eventId, context, message, args);
        }

        /// <summary>
        /// Formats and writes a warning log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogWarning(exception, context, "Error while processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogWarning(this ILogger logger, Exception? exception, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Warning, exception, context, message, args);
        }

        /// <summary>
        /// Formats and writes a warning log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogWarning(context"Processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogWarning(this ILogger logger, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Warning, context, message, args);
        }

        //------------------------------------------ERROR------------------------------------------//

        /// <summary>
        /// Formats and writes an error log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogError(0, exception, context, "Error while processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogError(this ILogger logger, EventId eventId, Exception? exception, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Error, eventId, exception, context, message, args);
        }

        /// <summary>
        /// Formats and writes an error log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogError(0, context, "Processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogError(this ILogger logger, EventId eventId, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Error, eventId, context, message, args);
        }

        /// <summary>
        /// Formats and writes an error log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogError(exception, context, "Error while processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogError(this ILogger logger, Exception? exception, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Error, exception, context, message, args);
        }

        /// <summary>
        /// Formats and writes an error log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogError(context, "Processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogError(this ILogger logger, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Error, context, message, args);
        }

        //------------------------------------------CRITICAL------------------------------------------//

        /// <summary>
        /// Formats and writes a critical log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogCritical(0, exception, context, "Error while processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogCritical(this ILogger logger, EventId eventId, Exception? exception, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Critical, eventId, exception, context, message, args);
        }

        /// <summary>
        /// Formats and writes a critical log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogCritical(0, context, "Processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogCritical(this ILogger logger, EventId eventId, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Critical, eventId, context, message, args);
        }

        /// <summary>
        /// Formats and writes a critical log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogCritical(exception, context, "Error while processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogCritical(this ILogger logger, Exception? exception, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Critical, exception, context, message, args);
        }

        /// <summary>
        /// Formats and writes a critical log message.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message in message template format. Example: <c>"User {User} logged in from {Address}"</c>.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        /// <example>
        /// <code language="csharp">
        /// logger.LogCritical(context, "Processing request from {Address}", address)
        /// </code>
        /// </example>
        [HideInCallstack]
        public static void LogCritical(this ILogger logger, Object? context, string? message, params object?[] args)
        {
            logger.Log(LogLevel.Critical, context, message, args);
        }

        /// <summary>
        /// Formats and writes a log message at the specified log level.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="logLevel">Entry will be written on this level.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        [HideInCallstack]
        public static void Log(this ILogger logger, LogLevel logLevel, Object? context, string? message, params object?[] args)
        {
            logger.Log(logLevel, 0, null, context, message, args);
        }

        /// <summary>
        /// Formats and writes a log message at the specified log level.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="logLevel">Entry will be written on this level.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        [HideInCallstack]
        public static void Log(this ILogger logger, LogLevel logLevel, EventId eventId, Object? context, string? message, params object?[] args)
        {
            logger.Log(logLevel, eventId, null, context, message, args);
        }

        /// <summary>
        /// Formats and writes a log message at the specified log level.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="logLevel">Entry will be written on this level.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        [HideInCallstack]
        public static void Log(this ILogger logger, LogLevel logLevel, Exception? exception, Object? context, string? message, params object?[] args)
        {
            logger.Log(logLevel, 0, exception, context, message, args);
        }

        /// <summary>
        /// Formats and writes a log message at the specified log level.
        /// </summary>
        /// <param name="logger">The <see cref="ILogger"/> to write to.</param>
        /// <param name="logLevel">Entry will be written on this level.</param>
        /// <param name="eventId">The event id associated with the log.</param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="message">Format string of the log message.</param>
        /// <param name="args">An object array that contains zero or more objects to format.</param>
        [HideInCallstack]
        public static void Log(this ILogger logger, LogLevel logLevel, EventId eventId, Exception? exception, Object? context, string? message, params object?[] args)
        {
            if (logger is null)
            {
                throw new ArgumentNullException(nameof(logger));
            }

            if (logger is UnityConsoleLogger.UnityConsoleLogger unityConsoleLogger)
            {
                unityConsoleLogger.Log(logLevel, eventId, context, new FormattedLogValues(message, args), exception, _messageFormatter);
            }
            else
            {
                logger.Log(logLevel, eventId, new FormattedLogValues(message, args), exception, _messageFormatter);
            }
        }

        private static string MessageFormatter(FormattedLogValues state, Exception? error)
        {
            return state.ToString();
        }
    }
}