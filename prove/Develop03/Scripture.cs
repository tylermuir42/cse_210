class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    private string _bookName;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;
    private string _text;

    public Scripture(string name, int chapter, int verse, string text)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = verse;
        _text = text;

        ConvertToWords(_text);
    }

    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _bookName = name;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _text = text;

        ConvertToWords(_text);
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;

        ConvertToWords(_text);
    }

    public void ShowScripture()
    {
        Console.WriteLine(GetScripture());
    }

    public string GetScripture()
    {
        return GetScriptureString();
    }

    private string GetScriptureString()
    {
        string referenceLine;

        if (_startVerse == 0 && _endVerse == 0)
        {
            referenceLine =  $"{_bookName} {_chapter}: {_verse}";
        }
        else
        {
            referenceLine = $"{_bookName} {_chapter}: {_startVerse}-{_endVerse}";
        }

        string scriptureText = "";

        foreach (Word w in _words)
        {
            scriptureText += w.GetWordString() + " ";
        }

        return referenceLine + "\n" + scriptureText.TrimEnd();
    }

    public bool HideWords()
    {
        Random rand = new Random();
        int wordsToHide = 3;

        var visibleWords = _words.Where(_words => !_words.IsHidden()).ToList();

        if (visibleWords.Count == 0)
        {
            return false;
        }

        for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].HideWord();
            visibleWords.RemoveAt(index);
        }

        return true;
    }

    // private int NumberOfHiddenWords()
    // {
    //     return 3;
    // }
    
    private void ConvertToWords(string _text)
    {
        string[] parts = _text.Split(' ');

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }
}