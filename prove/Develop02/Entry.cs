class Entry
{
    public string[] _promptStrings =
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string _promptText;
    public string _entryText;
    public string _date;

    public string GetPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(0, _promptStrings.Length);
        _promptText = _promptStrings[index];

        Console.WriteLine(_promptText);
        return _promptText;
    }

    public string inputEntry()
    {
        string userInput = Console.ReadLine();
        _entryText = userInput;
        return userInput;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"{_entryText} \n");
    }
}