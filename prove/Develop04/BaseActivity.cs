class BaseActivity
{
    string _name = "";
    string _description = "";
    int _duration;
    DateTime _endTime;

    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
        _endTime = DateTime.Now;
    }

    public void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
    }
}