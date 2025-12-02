using System;

class Program
{
    static void Main(string[] args)
    {
        Goals goalsManager = new Goals();
        Menu menu = new Menu();
        int response = 0;

        while(response != 6)
        {
            Console.WriteLine($"\nYou have {goalsManager.GetTotalPoints()} points.\n");
            response = menu.DisplayMenu();

            switch(response)
            {
                case 1: // Create Goal
                    menu.DisplayCreateGoalMenu();
                    int goalType = int.Parse(Console.ReadLine());
                    Goal newGoal = null;

                    if (goalType == 1) { newGoal = new SimpleGoal(); }
                    else if (goalType == 2) { newGoal = new EternalGoal(); }
                    else if (goalType == 3) { newGoal = new CheckListGoal(); }

                    if (newGoal != null)
                    {
                        newGoal.CreateGoal();
                        goalsManager.AddGoal(newGoal);
                    }
                    break;
                case 2: // List Goals
                    goalsManager.DisplayGoals();
                    break;
                case 3: // Save Goals
                    goalsManager.SaveGoals();
                    break;
                case 4: // Load Goals
                    goalsManager.LoadGoals();
                    break;
                case 5: // Record Event
                    goalsManager.RecordEvent();
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