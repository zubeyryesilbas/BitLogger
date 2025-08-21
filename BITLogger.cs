using UnityEngine;

public static class BITLogger
{
    public enum LogColor
    {
        White,
        Red,
        Green,
        Blue,
        Yellow,
        Cyan,
        Magenta
    }

    private static string ColorToHex(LogColor color)
    {
        switch (color)
        {
            case LogColor.Red: return "red";
            case LogColor.Green: return "green";
            case LogColor.Blue: return "blue";
            case LogColor.Yellow: return "yellow";
            case LogColor.Cyan: return "cyan";
            case LogColor.Magenta: return "magenta";
            default: return "white";
        }
    }

    public static void Log(string message, LogColor color = LogColor.White, string header = "")
    {
        string prefix = string.IsNullOrEmpty(header) ? "" : $"[{header}] ";
        Debug.Log($"<color={ColorToHex(color)}>{prefix}{message}</color>");
    }

    public static void LogWarning(string message, string header = "")
    {
        string prefix = string.IsNullOrEmpty(header) ? "" : $"[{header}] ";
        Debug.LogWarning($"<color=yellow>{prefix}{message}</color>");
    }

    public static void LogError(string message, string header = "")
    {
        string prefix = string.IsNullOrEmpty(header) ? "" : $"[{header}] ";
        Debug.LogError($"<color=red>{prefix}{message}</color>");
    }
}
