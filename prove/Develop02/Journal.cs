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

    public void LoadFromFile(string filename)
    {
        Console.WriteLine($"Loading from {filename}");
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            Entry loadedEntry = new Entry();

            loadedEntry._date = parts[0];
            loadedEntry._promptText = parts[1];
            loadedEntry._entryText = parts[2];

            _entries.Add(loadedEntry);
        }
        Console.WriteLine("Load complete");
    }
}