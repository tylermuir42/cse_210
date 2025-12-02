class SimpleGoal : Goal
{
    public SimpleGoal() : base(){}

    public SimpleGoal(string name, string description, int points, bool status) : base(name, description, points)
    {
        SetStatus(status);
    }

    public override void CreateGoal()
    {
        Console.Write("Enter the name of the goal: ");
        SetName(Console.ReadLine());

        Console.Write("Enter a short description of the goal: ");
        SetDescription(Console.ReadLine());

        Console.Write("Enter the number of points associated with this goal: ");
        SetNumberOfPoints(int.Parse(Console.ReadLine()));

        SetStatus(false); // Simple goals start as incomplete
    }

    public override int RecordEvent()
    {
        if (!GetStatus())
        {
            SetStatus(true);
            Console.WriteLine($"Congratulations! You have earned {GetNumberOfPoints()} points!");
            return GetNumberOfPoints();
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }
    }

    public override string GetFileString()
    {
        return $"Simple Goal:{GetName()},{GetDescription()},{GetNumberOfPoints()},{GetStatus()}";
    }
}