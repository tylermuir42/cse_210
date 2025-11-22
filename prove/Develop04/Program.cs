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
                    breathingActivity.DisplayEnding();
                    Thread.Sleep(10000);
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.", 10);
                    reflectionActivity.StartReflectionActicity();
                    break;
                // case 3:
                //     ListingActivity listingActivity = new ListingActivity();
                //     listingActivity.Start();
                //     break;
                case 4:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}