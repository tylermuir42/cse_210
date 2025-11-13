class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(string name, int chapter, int verse, string text)
    {

    }

    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {

    }

    public Scripture(Reference _reference, string text)
    {

    }

    public bool HideWords()
    {
        return _words.Count > 0;
    }

    public void ShowScripture()
    {

    }

    public string GetScriptureReference()
    {
        return "";
    }

    private int NumberOfHiddenWords()
    {
        return 0;
    }
    
    private string ConvertToWords(string text)
    {
        return "";
    }
}