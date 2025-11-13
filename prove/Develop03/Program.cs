using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Uncle");
        Console.WriteLine(myWord.GetWordString());
        myWord.DisplayWord();
        myWord.HideWord();
        if (myWord.IsHidden())
        {
            Console.WriteLine("Word is hidden");
        }

        Console.WriteLine(myWord.GetWordString());
        myWord.DisplayWord();

        var reference1 = new Reference("John", 3, 16);
        Console.WriteLine(reference1.GetScriptureReference());
        reference1.ShowScriptureReference();

        var reference2 = new Reference("Proverbs", 3, 5, 6);
        Console.WriteLine(reference2.GetScriptureReference());
        reference2.ShowScriptureReference();
    }
}