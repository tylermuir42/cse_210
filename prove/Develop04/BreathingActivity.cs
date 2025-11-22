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
    private void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    public void StartBreathingActivity(int totalDuration)
    {
        Console.WriteLine("Starting Breathing Exercise...");
        DateTime endTime = DateTime.Now.AddSeconds(totalDuration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe In...");
            Pause(_breathInDuration);
            Console.WriteLine("Breathe Out...");
            Pause(_breathOutDuration);
        }

        Console.WriteLine("Breathing Exercise Completed!");
    }
}