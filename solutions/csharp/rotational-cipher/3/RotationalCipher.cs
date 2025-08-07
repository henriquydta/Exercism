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
        
        char[] rotatedText = new char[text.Length];
        
        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            // Console.WriteLine((int)c);
            
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                rotatedText[i] = (char)(((c - offset + shiftKey) % 26) + offset);
            }
            else
            {
                rotatedText[i] = c;
            }
        }

        return new string(rotatedText);
    }
}