using System.Text;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        StringBuilder newString = new StringBuilder();
        
        for (int i = input.Length - 1; i >= 0; i--)
        {
            newString.Append(input[i]);
        }

        return newString.ToString();
    }
}