static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        var successRate = speed switch
        {
            >= 1 and <= 4 => 1.0,
            >= 5 and <= 8 => 0.9,
            9 => 0.8,
            10 => 0.77,
            _ => 0.0
        };

        return successRate;
    }
    
    public static double ProductionRatePerHour(int speed) => speed * 221 * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed)
    {
        var workingItems = ProductionRatePerHour(speed) / 60;
        return (int)workingItems;
    }
}
