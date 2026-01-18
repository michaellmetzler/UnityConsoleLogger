using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityConsoleLogger
{
    [Serializable]
    public class LogFilter
    {
        public string category;
        public LogLevel logLevel;
    }

    [CreateAssetMenu(fileName = "LogFilter", menuName = "Scriptable Objects/UnityConsole/LogFilter")]
    public class UnityConsoleLogFilter: ScriptableObject
    {
        public List<LogFilter> filters;
    }
}
