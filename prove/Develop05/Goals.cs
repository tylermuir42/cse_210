using System.IO.Compression;

class Goals
{
    private List<Goal> _goals;
    private int _totalPoints;

    public Goals()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetConsoleString()}");
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            int pointsEarned = _goals[choice].RecordEvent();
            _totalPoints += pointsEarned;
            Console.WriteLine($"You now have {_totalPoints} total points.");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalPoints);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetFileString());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _totalPoints = int.Parse(reader.ReadLine());
                _goals.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');
                    string goalType = parts[0];
                    string[] data = parts[1].Split(',');

                    Goal goal = null;
                    switch (goalType)
                    {
                        case "Simple Goal":
                            goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3]));
                            break;
                        case "Eternal Goal":
                            goal = new EternalGoal(data[0], data[1], int.Parse(data[2]));
                            break;
                        case "CheckList Goal":
                            goal = new CheckListGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), bool.Parse(data[6]));
                            break;
                    }
                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}