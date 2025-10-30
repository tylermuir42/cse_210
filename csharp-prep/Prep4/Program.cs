using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool end = false;
        string numStr;
        int count = 0;
        float total = 0;

        while (end == false)
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            numStr = Console.ReadLine();
            int number = int.Parse(numStr);

            numbers.Add(number);
            count++;

            if (number == 0)
            {
                end = true;
            }
        }

        foreach (int number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum is :{total.ToString()}");

        float average = total / (count - 1);
        Console.WriteLine($"The average is: {average.ToString()}");

        numbers.Sort();
        int largest = numbers[numbers.Count - 1];
        Console.WriteLine($"The largest number in the list is {largest}.");

        Console.WriteLine("Your sorted list: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}