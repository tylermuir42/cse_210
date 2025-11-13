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

        Reference myReference = new Reference();
        Console.WriteLine(myReference.ScriptureReference("John", 3, 16));

        Reference reference2 = new Reference();
        Console.WriteLine(reference2.ScriptureReference("Poverbs", 3, 5, 6));
    }
}