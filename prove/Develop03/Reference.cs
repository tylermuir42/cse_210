class Reference
{
    private string _bookName;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;

    public Reference (string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference (string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void ShowScriptureReference()
    {
        Console.WriteLine(GetScriptureReferenceString());
    }

    public string GetScriptureReference()
    {
        return GetScriptureReferenceString();
    }
    
    private string GetScriptureReferenceString()
    {
        if(_startVerse == 0 && _endVerse == 0)
        {
            return $"{_bookName} {_chapter}: {_verse}";
        }
        else
        {
            return $"{_bookName} {_chapter}: {_startVerse}-{_endVerse}";
        }
    }
}