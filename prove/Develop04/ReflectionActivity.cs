class ReflectionActivity : BaseActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void StartReflectionActicity()
    {
        DisplayGreeting();
        ObtainDuration();
        RunCountDown("Get ready...", 5);
        
        string prompt = GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        RunCountDown("You may begin in:", 5);

        StartTimer();
        while (!IsTimeUp())
        {
            string question = GetRandomQuestion();
            Console.Write($"> {question} ");

            DisplaySpinner("", 3);
        }

        Console.WriteLine();
        DisplaySpinner("Well done for reflecting!", 5);
        DisplayEnding();
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}