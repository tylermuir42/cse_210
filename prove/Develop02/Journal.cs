class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry userInput)
    {
         _entries.Add(userInput);
    }
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
}