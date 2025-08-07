using Xunit.Internal;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        char[] separators = [' ', '-'];
        string[] words = phrase.Split(separators);
        words = words.WhereNotNullOrWhitespace().ToArray();
        
        char[] acronymLetters = new char[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            acronymLetters[i] = char.ToUpper(words[i].First(char.IsLetter));
        }

        return new string(acronymLetters);
    }
}