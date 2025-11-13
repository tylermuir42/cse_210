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
    }
}