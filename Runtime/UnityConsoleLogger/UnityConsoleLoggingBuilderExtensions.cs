using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using System;
using UnityConsoleLogger;

namespace Microsoft.Extensions.Logging
{
    public static class UnityConsoleLoggingBuilderExtensions
    {
        public static ILoggingBuilder AddUnityConsoleLogger(this ILoggingBuilder builder)
        {
            builder.AddConfiguration();

            builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, UnityConsoleLoggerProvider>());

            LoggerProviderOptions.RegisterProviderOptions<UnityConsoleLoggerConfiguration, UnityConsoleLoggerProvider>(builder.Services);

            return builder;
        }

        public static ILoggingBuilder AddUnityConsoleLogger(this ILoggingBuilder builder, Action<UnityConsoleLoggerConfiguration> configure)
        {
            builder.AddUnityConsoleLogger();

            builder.Services.Configure(configure);

            return builder;
        }
    }
}