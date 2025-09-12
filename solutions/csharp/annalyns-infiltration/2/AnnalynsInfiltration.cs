static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if (knightIsAwake || archerIsAwake || prisonerIsAwake)
        {return true;}
        else
        {return false;}
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (prisonerIsAwake && !archerIsAwake)
        {return true;}
        else
        {return false;}
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if ((petDogIsPresent) && (!knightIsAwake && !archerIsAwake))
        {return true;}
        else if (petDogIsPresent && !(archerIsAwake || !knightIsAwake))
        {return true;}
        else if (prisonerIsAwake && (!knightIsAwake && !archerIsAwake))
        {return true;}
        else
        {return false;}
    }
}
