#nullable enable

using System;
using System.Text;
using UnityEngine;
using Microsoft.Extensions.Logging;

namespace UnityConsoleLogger
{
    public class UnityConsoleLogger : Microsoft.Extensions.Logging.ILogger
    {
        private static UnityEngine.ILogger _unityLogger = Debug.unityLogger;

        private string _name;
        private Func<UnityConsoleLoggerConfiguration> _getCurrentConfig;

        private StringBuilder _logBuilder;

        public UnityConsoleLogger(string name, Func<UnityConsoleLoggerConfiguration> getCurrentConfig)
        {
            _name = name;
            _getCurrentConfig = getCurrentConfig;

            _logBuilder = new StringBuilder();
        }
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => default!;

        public bool IsEnabled(LogLevel logLevel) =>
            _getCurrentConfig().LogLevelToColorMap.ContainsKey(logLevel);

        [HideInCallstack]
        public void Log<TState>(LogLevel logLevel,
                                EventId eventId,
                                TState state,
                                Exception? exception,
                                Func<TState, Exception?, string> formatter)
        {
            Log(logLevel, eventId, null, state, exception, formatter);
        }

        [HideInCallstack]
        public void Log<TState>(LogLevel logLevel,
                                EventId eventId,
                                UnityEngine.Object? context,
                                TState state,
                                Exception? exception,
                                Func<TState, Exception?, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            if (exception != null)
            {
                _unityLogger.LogException(exception);
                return;
            }

            UnityConsoleLoggerConfiguration config = _getCurrentConfig();
            if (config.EventId == 0 || config.EventId == eventId.Id)
            {
                var color = config.LogLevelToColorMap[logLevel];

                var logType = LogType.Log;

                if(logLevel == LogLevel.Error ||
                   logLevel == LogLevel.Critical)
                {
                    logType = LogType.Error;
                }
                else if(logLevel == LogLevel.Warning)
                {
                    logType = LogType.Warning;
                }

                _logBuilder.Clear();
                _logBuilder.Append("<color=#");
                _logBuilder.Append(ColorUtility.ToHtmlStringRGB(color));
                _logBuilder.Append(">");
                _logBuilder.Append(logLevel);
                _logBuilder.Append(": ");
                _logBuilder.Append("</color> ");
                _logBuilder.Append(formatter(state, exception));

                _unityLogger.Log(logType, _name, _logBuilder.ToString(), context);
            }
        }
    }
}