class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int minutesInOven)
    {
        return 40 - minutesInOven;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    public int ElapsedTimeInMinutes(int layersAdded, int minutesInOven)
    {
        return layersAdded * 2 + minutesInOven;
    }
}
