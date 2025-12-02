abstract class Goal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = false; // Default status is incomplete
    }

    public Goal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false; // Default status is incomplete
    }

    public string GetName() => _name;
    public void SetName(string name) => _name = name;

    public string GetDescription() => _description;
    public void SetDescription(string description) => _description = description;
    
    public int GetNumberOfPoints() => _numberOfPoints;
    public void SetNumberOfPoints(int points) => _numberOfPoints = points;
    
    public bool GetStatus() => _status;
    public void SetStatus(bool status) => _status = status;

    public virtual string GetConsoleString()
    {
        string checkMark = _status ? "[X]" : "[ ]";
        return $"{checkMark} {_name} ({_description})";
    }

    public abstract void CreateGoal();
    public abstract int RecordEvent();
    public abstract string GetFileString();
    
}