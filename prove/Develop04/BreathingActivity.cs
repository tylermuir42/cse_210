class BreathingActivity : BaseActivity
{
    private int _breathInDuration;
    private int _breathOutDuration;

    public BreathingActivity(string name, string description, int duration, int breathInDuration, int breathOutDuration)
        : base(name, description, duration)
    {
        _breathInDuration = breathInDuration;
        _breathOutDuration = breathOutDuration;
    }

    public void StartBreathingActivity()
    {
        DisplayGreeting();
        ObtainDuration();
        RunCountDown("Get ready...", 5);
        StartTimer();

        while (!IsTimeUp())
        {
            RunCountDown("Breathe in...", _breathInDuration);
            RunCountDown("Breathe out...", _breathOutDuration);
        }

        Console.WriteLine();
        DisplaySpinner("Take another deep breath...", 5);
    }
}