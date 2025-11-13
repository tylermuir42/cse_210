class Reference
{
    private string _bookName;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;

    public string ScriptureReference(string name, int chapter, int verse)
    {
        _bookName = name;
        _chapter = chapter;
        _verse = verse;
        return $"{name} {chapter}: {verse}";
    }

    public string ScriptureReference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        return $"{name} {chapter}: {startVerse}-{endVerse}";
    }

    public void ShowScriptureReference()
    {

    }

    public string GetScriptureReference()
    {
        return "";
    }
    
    private string GetScriptureReferenceString()
    {
        return "";
    }
}