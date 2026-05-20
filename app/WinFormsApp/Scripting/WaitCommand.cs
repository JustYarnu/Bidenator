public class WaitCommand : IMacroCommand
{
    public int MinDelay { get; }
    public int MaxDelay { get; }

    public WaitCommand(int delay) : this(delay, delay) { }

    public WaitCommand(int min, int max)
    {
        MinDelay = min;
        MaxDelay = max;
    }

    public void Execute(InputController controller)
    {
        if (MinDelay == MaxDelay)
            controller.Wait(MinDelay);
        else
            controller.RandomWait(MinDelay, MaxDelay);
    }
}