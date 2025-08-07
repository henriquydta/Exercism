public static class SimpleCalculator
{
    public static string? Calculate(int operand1, int operand2, string? operation)
    {
        try
        {
            if (operand2 == 0 && operation == "/")
                return ("Division by zero is not allowed.");
            
            if (!string.IsNullOrEmpty(operation) && operation.Length > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(operation), "Argument must be valid");
            }

            ArgumentNullException.ThrowIfNull(operation);

            if (operation == "")
            {
                throw new ArgumentException("Operation must not be an empty string.", nameof(operation));
            }
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e);
            throw;
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e);
            throw;
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e);
            throw;
        }

        switch (operation)
        {
            case "+":
                return $"{operand1} + {operand2} = {operand1 + operand2}";
            case "*":
                return $"{operand1} * {operand2} = {operand1 * operand2}";
            case "/":
                return $"{operand1} / {operand2} = {operand1 / operand2}";
        }

        return null;
    }
}
