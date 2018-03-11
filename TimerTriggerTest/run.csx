using System;

public static string Run(TimerInfo myTimer, TraceWriter log)
{
    var message = $"C# Timer trigger function executed at: {DateTime.Now}";
    log.Info(message);
    return message;
}
