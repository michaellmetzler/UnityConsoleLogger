using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityConsoleLogger
{
    [Serializable]
    public class LogLevelColor
    {
        public LogLevel logLevel;
        public Color color;
    }

    [CreateAssetMenu(fileName = "LogLevelColor", menuName = "Scriptable Objects/UnityConsole/LogLevelColor")]
    public class UnityConsoleLogLevelColor: ScriptableObject
    {
        public List<LogLevelColor> colors;
    }
}
