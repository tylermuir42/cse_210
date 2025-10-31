using System;

class Program
{
    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string promptUserName()
    {
        Console.Write("Please ener your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int promptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numStr = Console.ReadLine();
        int number = int.Parse(numStr);
        return number;
    }
    static void promptUserBirthYear(out int birthYear)
    {
        Console.Write("Enter the year you were born: ");
        string input = Console.ReadLine();
        birthYear = int.Parse(input);
    }
    static int squareNumber( int num)
    {
        int squared = num * num;
        return squared; 
    }
    static void displayResult()
    {
        promptUserName();
        int num = promptUserNumber();

        int year;
        promptUserBirthYear(out year);
        Console.WriteLine($"You were born in {year}.");

        squareNumber(num);

        int currentYear = DateTime.Now.Year;
        int age = currentYear - year;
        Console.WriteLine($"You are {age} years old.");
    }
    static void Main(string[] args)
    {
        displayWelcome();
        displayResult();
    }
}