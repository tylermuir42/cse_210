class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal() : base()
    {
        _amountCompleted = 0;
        _target = 0;
        _bonus = 0;
    }

    public CheckListGoal(string name, string description, int points, int target, int bonus, int amountCompleted, bool status) : base(name, description, points)
    {
        SetStatus(status);
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;   
    }

    public override void CreateGoal()
    {
        Console.Write("Enter the name of the goal: ");
        SetName(Console.ReadLine());

        Console.Write("Enter a short description of the goal: ");
        SetDescription(Console.ReadLine()); 

        Console.Write("Enter the number of points associated with this goal: ");
        SetNumberOfPoints(int.Parse(Console.ReadLine()));

        Console.Write("Enter the number of times this goal needs to be accomplished for a bonus: ");
        _target = int.Parse(Console.ReadLine());

        Console.Write("Enter the bonus points for completing this goal: ");
        _bonus = int.Parse(Console.ReadLine());

        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        int pointsEarned = 0;
        _amountCompleted++;

        if(_amountCompleted >= _target)
        {
            SetStatus(true);
            pointsEarned = GetNumberOfPoints() + _bonus;
            Console.WriteLine($"Congratulations! You have completed the checklist goal and earned {pointsEarned} points!");
        }
        else
        {
            pointsEarned = GetNumberOfPoints();
            Console.WriteLine($"You have earned {pointsEarned} points! {_target - _amountCompleted} more to go for a bonus.");
        }
        return pointsEarned;
    }

    public override string GetConsoleString()
    {
        string checkMark = GetStatus() ? "[X]" : "[ ]";
        return $"{checkMark} {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetFileString()
    {
        return $"CheckList Goal:{GetName()},{GetDescription()},{GetNumberOfPoints()},{_target},{_bonus},{_amountCompleted},{GetStatus()}";
    }
}