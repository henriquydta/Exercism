public static class Pangram
{
    public static bool IsPangram(string input)
    {
        var lettersInInput = input.Trim().ToUpper().Distinct().Where(char.IsLetter).ToArray();
        return lettersInInput.Length == 26;
    }
}
