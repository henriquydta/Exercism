public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        string result = "";
        int letterQuantity = 0;

        for (int i = 0; i < input.Length; i++)
        {
            var currentLetter = input[i];
            if (i == 0) 
                letterQuantity++;

            if (i == input.Length - 1)
            {
                _ = letterQuantity > 1 ? result += letterQuantity.ToString() + currentLetter : result += currentLetter;
                continue;
            }
            
            if (currentLetter.Equals(input[i + 1]))
            {
                letterQuantity++;
            }
            else
            {
                if (letterQuantity == 1)
                {
                    result += currentLetter;
                }
                else
                {
                    result += letterQuantity.ToString() + currentLetter;
                    letterQuantity = 1;
                }
            }
        }

        return result;
    }

    public static string Decode(string input)
    {
        string result = "";
        string numberString = "";

        foreach (var currentChar in input)
        {
            if (char.IsNumber(currentChar))
            {
                numberString += currentChar;
            }
            else
            {
                int charQuantity = 1;
                if (!string.IsNullOrEmpty(numberString))
                {
                    charQuantity = int.Parse(numberString);
                }

                if (charQuantity == 1)
                {
                    result += currentChar;
                }
                else
                {
                    for (int i = 0; i < charQuantity; i++)
                    {
                        result += currentChar;
                    }

                    numberString = "";
                }
            }
        }

        return result;
    }
}
