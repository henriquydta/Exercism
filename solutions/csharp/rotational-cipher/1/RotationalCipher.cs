public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        switch (shiftKey)
        {
            case < 0 or > 26:
                throw new Exception("Variable 'shiftKey' is invalid.");
            case 0 or 26:
                return text;
        }

        char[] alphabet =
        [
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
            'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
            'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
            'y', 'z'
        ];

        char[] textArray = text.ToArray();
        char[] rotatedText = new char[textArray.Length];
        
        for (int i = 0; i < text.Length; i++)
        {
            int j = 0;
            bool isUpper = char.IsUpper(textArray[i]);
            bool isSpecialCharacter = char.IsNumber(textArray[i]) || char.IsPunctuation(textArray[i]) || char.IsWhiteSpace(textArray[i]);
            
            if (isSpecialCharacter)
                rotatedText[i] = textArray[i];
            
            foreach (var character in alphabet)
            {
                if (character == char.ToLower(textArray[i]))
                {
                    var aux = j + shiftKey >= 26 ? (j + shiftKey) - 26 : j + shiftKey;  
                    var newChar = alphabet[aux];
                    _ = isUpper ? rotatedText[i] = char.ToUpper(newChar) : rotatedText[i] = newChar;
                    break;
                }

                j++;
            }
        }

        return new string(rotatedText);
    }
}