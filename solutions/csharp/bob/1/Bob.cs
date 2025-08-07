public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();
        
        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";
        
        if (statement.Any(char.IsLetter) && !statement.Any(char.IsLower) && statement.Last().Equals('?'))
            return "Calm down, I know what I'm doing!";
        
        if (statement.Last().Equals('?'))
            return "Sure.";

        if (!statement.Any(char.IsLower) && statement.Any(char.IsLetter))
            return "Whoa, chill out!";

        return "Whatever.";
    }
}