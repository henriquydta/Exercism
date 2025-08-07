public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var chars = word.ToLower().Distinct().Where(char.IsLetter).Count();
        return chars == word.Where(char.IsLetter).Count();
    }
}
