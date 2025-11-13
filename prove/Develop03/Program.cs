using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Uncle");
        myWord.DisplayWord();
        myWord.HideWord();
        if (myWord.IsHidden())
        {
            Console.WriteLine("Word is hidden");
        }
    }
}