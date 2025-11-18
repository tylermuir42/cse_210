class WritingAssignment : Assignment
{
    private string _title;
    private string _dueDate;

    public WritingAssignment(string title, string dueDate, string studentName, string topic)
        : base(studentName, topic)
    {
        _title = title;
        _dueDate = dueDate;
    }

    public string GetWritingInfo()
    {
        return $"{GetSummary()}\nTitle: {_title}\nDue Date: {_dueDate}";
    }
}