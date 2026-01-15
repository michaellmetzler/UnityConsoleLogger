using System.Collections.Generic;

using Microsoft.Extensions.Logging;
using UnityEngine;

namespace UnityConsoleLogger
{
    public sealed class UnityConsoleLoggerConfiguration
    {
        public int EventId { get; set; }

        public Dictionary<LogLevel, Color> LogLevelToColorMap { get; set; } = new()
        {
            [LogLevel.Information] = Color.green,
        };
    }
}