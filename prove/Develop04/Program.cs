using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();

        int response = 0;
        while (response != 4)
        {
            response = menu.DisplayMenu();

            switch (response)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by guiding you through breathing exercises.", 10, 4, 6);
                    breathingActivity.StartBreathingActivity();
                    LogActivityCompletion("Breathing Activity");
                    breathingActivity.DisplayEnding();
                    Thread.Sleep(3000);
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.", 10);
                    reflectionActivity.StartReflectionActicity();
                    LogActivityCompletion("Reflection Activity");
                    reflectionActivity.DisplayEnding();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 10);
                    listingActivity.StartListingActivity();
                    LogActivityCompletion("Listing Activity");
                    listingActivity.DisplayEnding();
                    break;
                case 4:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    Thread.Sleep(1500);
                    break;
            }
        }
    }

    private static Dictionary<string, int> _activityCounts = new Dictionary<string, int>()
    {
        {"Breathing Activity", 0},
        {"Reflection Activity", 0},
        {"Listing Activity", 0}
    };

    private static void LogActivityCompletion(string activityName)
    {
        if (_activityCounts.ContainsKey(activityName))
        {
            _activityCounts[activityName]++;
        }
        else
        {
            _activityCounts.Add(activityName, 1);
        }
    }

    public static void DisplayActivityStats()
    {
        Console.WriteLine("\n Activity Completion Statistics:");
        foreach (var entry in _activityCounts)
        {
            Console.WriteLine($"- {entry.Key}: Completed {entry.Value} time(s)");
        }
        Console.WriteLine();
    }

        
}