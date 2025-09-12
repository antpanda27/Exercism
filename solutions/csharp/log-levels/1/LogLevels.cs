static class LogLine
{
    public static string Message(string logLine)
    {
        int startingIndex = logLine.IndexOf(":") + 1;
        string message = logLine.Substring(startingIndex);
        return message.Trim();

    }

    public static string LogLevel(string logLine)
    {
        int startingIndex = logLine.IndexOf("[") + 1;
        int endingIndex = logLine.IndexOf("]");
        string logLevel = logLine.Substring(startingIndex, (endingIndex - startingIndex));
        return logLevel.ToLower();
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
