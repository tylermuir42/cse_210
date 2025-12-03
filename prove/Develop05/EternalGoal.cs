using System;

class EternalGoal : Goal
{
    public int _numberOfCompletions;

    public EternalGoal() : base() 
    {
        _numberOfCompletions = 0;
    }

    // Updated constructor to accept an existing count (for loading from file)
    public EternalGoal(string name, string description, int points, int completions) 
        : base(name, description, points)
    {
        _numberOfCompletions = completions;
    }

    public override void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());

        Console.Write("What is a short description of it? ");
        SetDescription(Console.ReadLine());

        Console.Write("What is the amount of points associated with this goal? ");
        SetNumberOfPoints(int.Parse(Console.ReadLine()));
        
        _numberOfCompletions = 0;
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++; // Increment the counter
        return GetNumberOfPoints();
    }
    
    public override string GetConsoleString()
    {
        // Display the count similar to ChecklistGoal
        return $"{base.GetConsoleString()} -- Completed: {_numberOfCompletions} times";
    }

    public override string GetFileString()
    {
        // Save the count at the end
        return $"Eternal Goal:{GetName()},{GetDescription()},{GetNumberOfPoints()},{_numberOfCompletions}";
    }
}