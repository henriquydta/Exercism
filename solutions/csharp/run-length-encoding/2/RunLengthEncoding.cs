using System.Text;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (string.IsNullOrEmpty(input)) return "";

        var result = new StringBuilder();
        int letterQuantity = 1;

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - 1 && input[i] == input[i + 1])
            {
                letterQuantity++;
            }
            else
            {
                if (letterQuantity > 1)
                    result.Append(letterQuantity);
                
                result.Append(input[i]);
                letterQuantity = 1;
            }
        }

        return result.ToString();
    }

    public static string Decode(string input)
    {
        if (string.IsNullOrEmpty(input)) return "";

        var result = new StringBuilder();
        var numberString = new StringBuilder();

        foreach (var currentChar in input)
        {
            if (char.IsDigit(currentChar))
            {
                numberString.Append(currentChar);
            }
            else
            {
                int quantity = 1;
                if (numberString.Length > 0)
                {
                    quantity = int.Parse(numberString.ToString());
                    numberString.Clear();
                }

                result.Append(currentChar, quantity);
            }
        }

        return result.ToString();
    }
}