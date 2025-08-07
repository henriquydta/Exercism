class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[6];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[6]+=1;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Any(count => count == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var sum = 0;

        for (var i = 0; i < numberOfDays; i++)
        {
            sum += birdsPerDay[i];
        }

        return sum;
    }

    public int BusyDays()
    {
        return birdsPerDay.Count(x => x >= 5);
    }
}
