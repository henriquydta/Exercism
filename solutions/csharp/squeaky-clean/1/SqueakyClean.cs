using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        // Inicia a construção da nova string
        var result = new StringBuilder();
        
        for (var i = 0; i < identifier.Length; i++)
        {
            var current = identifier[i];

            // Substitui os '_' por underline
            if (char.IsWhiteSpace(current))
            {
                result.Append('_');
            }
            // Adiciona CTRL caso o caractere seja de controle
            else if (char.IsControl(current))
            {
                result.Append("CTRL");
            }
            // Verifica se está em kebab-case
            else if (current == '-')
            {
                // Se não houver
                if (i + 1 >= identifier.Length) continue;
                var next = identifier[i + 1];
                result.Append(char.ToUpper(next));
                i++;
            }
            else if (char.IsLetter(current))
            {
                if (current is < 'α' or > 'ω') result.Append(current);
            }
        }

        return result.ToString();
    }
}