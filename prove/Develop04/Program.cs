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
                    breathingActivity.StartBreathingActivity(10);
                    breathingActivity.DisplayEnding();
                    Thread.Sleep(5000);
                    break;
                // case 2:
                //     ReflectingActivity reflectingActivity = new ReflectingActivity();
                //     reflectingActivity.Start();
                //     break;
                // case 3:
                //     ListingActivity listingActivity = new ListingActivity();
                //     listingActivity.Start();
                //     break;
                case 4:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
            }
        }
    }
}