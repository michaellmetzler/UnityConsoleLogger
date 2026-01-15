# UnityConsoleLogger
Custom Unity logging provider for [Microsoft.Extensions.Logging](https://learn.microsoft.com/en-us/dotnet/core/extensions/logging)

## Setup
1. Add Unity Nuget as a scoped registry ([Instructions](https://github.com/bdovaz/UnityNuGet?tab=readme-ov-file#usage))
2. Add `https://github.com/Relztem523/UnityConsoleLogger.git` as a package ([Instructions](https://docs.unity3d.com/6000.3/Documentation/Manual/upm-ui-giturl.html))

## Usage
``` csharp
using Microsoft.Extensions.Logging;

var loggerFactory = LoggerFactory.Create(builder =>
{
    builder.AddUnityConsoleLogger();
});

var logger = loggerFactory.CreateLogger<Program>();

logger.LogInformation("This message will appear in the Unity Console");
```
