class Lasagna
{
    
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int min)
    {
        return ExpectedMinutesInOven() - min;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    public int ElapsedTimeInMinutes(int layers, int min)
    {
        return PreparationTimeInMinutes(layers) + min;
    }
}
