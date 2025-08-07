static class LogLine
{
    public static string Message(string logLine)
    {
        var fullLog = logLine.Split(["]: "], 2, StringSplitOptions.None);
        return fullLog[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        var fullLog = logLine.Split(["]: "], 2, StringSplitOptions.None);
        return fullLog[0].TrimStart('[').ToLower();
    }

    public static string Reformat(string logLine)
    {
        var message = Message(logLine);
        var level = LogLevel(logLine);

        return $"{message} ({level})";
    }
}
