#nullable enable

using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Concurrent;

namespace UnityConsoleLogger
{
    [ProviderAlias("UnityConsole")]
    public sealed class UnityConsoleLoggerProvider : ILoggerProvider
    {
        private readonly IDisposable? _onChangeToken;
        private UnityConsoleLoggerConfiguration _currentConfig;
        private readonly ConcurrentDictionary<string, UnityConsoleLogger> _loggers =
            new(StringComparer.OrdinalIgnoreCase);

        public UnityConsoleLoggerProvider(IOptionsMonitor<UnityConsoleLoggerConfiguration> config)
        {
            _currentConfig = config.CurrentValue;
            _onChangeToken = config.OnChange(updatedConfig => _currentConfig = updatedConfig);
        }

        public ILogger CreateLogger(string categoryName) =>
            _loggers.GetOrAdd(categoryName, name => new UnityConsoleLogger(name, GetCurrentConfig));

        private UnityConsoleLoggerConfiguration GetCurrentConfig() => _currentConfig;

        public void Dispose()
        {
            _loggers.Clear();
            _onChangeToken?.Dispose();
        }
    }
}