class Goal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;

    string _goalType;

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
        _numberOfPoints = 0;
        _status = false; // Default status is incomplete
        _goalType = "";
    }

    public Goal()
    {
        _name = "";
        _description = "";
        _numberOfPoints = 0;
        _status = false; // Default status is incomplete
        _goalType = "";
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetNumberOfPoints()
    {
        return _numberOfPoints;
    }

    public void SetNumberOfPoints(int points)
    {
        _numberOfPoints = points;
    }

    public bool GetStatus()
    {
        return _status;
    }

    public void SetStatus(bool status)
    {
        _status = status;
    }

    public virtual string GetConsoleString()
    {
        return $"Name: {_name}, Description: {_description}, Points: {_numberOfPoints}, Status: {_status}";
    }
    
}