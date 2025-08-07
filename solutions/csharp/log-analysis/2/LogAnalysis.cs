using System.Text.RegularExpressions;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string separator) =>
        str.Split(separator)[1];

    public static string SubstringBetween(this string str, string separator1, string separator2) => 
        Regex.Match(str, $@"\{separator1}(.*?)\{separator2}").Groups[1].Value;

    public static string Message(this string str) => str.Split("]:")[1].Trim();
    
    public static string LogLevel(this string str) => 
        Regex.Match(str, @"\[(.*?)\]").Groups[1].Value;
}