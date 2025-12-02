class EternalGoal : Goal
{
    public EternalGoal() : base(){}

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void CreateGoal()
    {
        Console.Write("Enter the name of the goal: ");
        SetName(Console.ReadLine());

        Console.Write("Enter a short description of the goal: ");
        SetDescription(Console.ReadLine());

        Console.Write("Enter the number of points associated with this goal: ");
        SetNumberOfPoints(int.Parse(Console.ReadLine()));
    }

    public override int RecordEvent()
    {
        return GetNumberOfPoints();
    }

    public override string GetFileString()
    {
        return $"Eternal Goal:{GetName()},{GetDescription()},{GetNumberOfPoints()}";
    }
}