class BaseActivity
{
    string _name = "";
    string _description = "";
    int _duration = 0;
    DateTime _endTime;

    public BaseActivity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
        _endTime = DateTime.Now;
    }

    public void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
    }

    public void DisplayEnding()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
    }

    public void RunCountDown(string message, int seconds)
    //Check this method for errors later!
    {
        Console.Write(message);
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void DisplaySpinner(string message, int duration)
    //Check this one too!
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        string[] spinnerChars = { "|", "/", "-", "\\" };
        int i = 0;

        Console.Write(message + " ");

        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerChars[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % spinnerChars.Length;
        }
        Console.WriteLine();
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool IsTimeUp()
    {
        return DateTime.Now >= _endTime;
    }

    public void ObtainDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }
}