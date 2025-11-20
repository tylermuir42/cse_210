using System;

class Program
{
    static void Main(string[] args)
    {
        string animationString = "\\|/-";
        int sleepTime = 250;
        int duration = 9;
        int index = 0;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        // while(DateTime.Now < endTime)
        // {
        //     Console.Write(animationString[index++ % animationString.Length]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }

        int count = duration;
        // Console.CursorVisible = false;
        // while(DateTime.Now < endTime)
        // {
        //     Console.Write(count--);
        //     Thread.Sleep(1000);
        //     if(count >= 9)
        //     {
        //         Console.Write("b\b. \b\b");
        //     }
        //     else
        //     {
        //         Console.Write("\b");
        //     }
        //     Console.Write("\b");
        // }
        // Console.CursorVisible = true;

        Console.CursorVisible = false;
        string animationString2 = "(^_^)(-_-)";

        while(DateTime.Now < endTime)
        {
            Console.Write(animationString2[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b\b");
            Console.Write(animationString2[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b\b");
        }
        Console.CursorVisible = true;
    }
}