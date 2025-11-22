class ListingActivity : BaseActivity
{
    private List<string> _prompts = new List<string>()
    {
        "List as many animals as you can think of.",
        "List as many countries as you can.",
        "List as many fruits as you can.",
        "List as many programming languages as you know.",
        "List as many musical instruments as you can.",
        "List as many cities as you can think of.",
        "List as many sports as you can.",
        "List as many movies as you can.",
        "List as many books as you have read."
    };

    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
    }

    public void StartListingActivity()
    {
        DisplayGreeting();
        ObtainDuration();
        RunCountDown("Get ready...", 5);

        string prompt = GetRandomPrompt();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        RunCountDown("You may begin in...", 5);

        StartTimer();
        int itemCount = 0;

        while (!IsTimeUp())
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemCount++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {itemCount} items.");
        DisplaySpinner("Well done for listing items!", 5);
        DisplayEnding();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}