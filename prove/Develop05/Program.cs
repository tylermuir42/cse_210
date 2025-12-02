using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int response = 0;
        while(response != 6)
        {
            response = menu.DisplayMenu();

            switch(response)
            {
                case 1:
                    menu.DisplayCreateGoalMenu();
                    Goal newGoal = new Goal("Sample Goal", "This is a sample goal description.");
                    Console.WriteLine(newGoal.GetConsoleString());
                    break;
                case 2:
                    // Logic for listing goals would go here
                    break;
                case 3:
                    // Logic for saving goals would go here
                    break;
                case 4:
                    // Logic for loading goals would go here
                    break;
                case 5:
                    // Logic for recording an event would go here
                    break;
                case 6:
                    Console.WriteLine("Quitting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}