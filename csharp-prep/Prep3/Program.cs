using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        //Console.WriteLine(number);

        bool response = false;
        string guess;

        int count = 0;

        while (response == false)
        {
            Console.Write("Guess my number: ");
            guess = Console.ReadLine();
            int guessNum = int.Parse(guess);

            if (guessNum == number)
            {
                Console.Write("That's right!");
                response = true;
            }
            else if (guessNum > number)
            {
                Console.WriteLine("Lower!");
                count++;
            }
            else if (guessNum < number)
            {
                Console.WriteLine("Higher!");
                count++;
            }
        }
        Console.WriteLine($" It took you {count} attempts");
    }
}