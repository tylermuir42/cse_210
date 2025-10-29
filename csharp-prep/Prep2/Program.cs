using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();

        int grade = int.Parse(userInput);
        string letter = "";
        bool pass = false;

        if (grade >= 90)
        {
            letter = "A";
            pass = true;
        }
        else if (grade >= 80)
        {
            letter = "B";
            pass = true;
        }
        else if (grade >= 70)
        {
            letter = "C";
            pass = true;
        }
        else if (grade >= 60)
        {
            letter = "D";
            pass = false;
        }
        else if (grade < 60)
        {
            letter = "F";
            pass = false;
        }
        Console.WriteLine($"Grade: {letter}");
        if (pass)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed! Try again");
        }
        
    }
}