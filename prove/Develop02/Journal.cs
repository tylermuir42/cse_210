using System.IO;

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

    public void SaveToFile(string filename)
    {
        Console.WriteLine($"Saving to {filename}...");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                string line = $"{entry._date}|{entry._promptText}|{entry._entryText}";
                outputFile.WriteLine(line);
            }
        }
        Console.WriteLine("Save complete!");
    }
}