class Journal
{
    DateTime theCurrentTime = DateTime.Now;
    //public string dateText = theCurrentTime.ToShortDateString();

    private List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.inputEntry());
        }
    }
}