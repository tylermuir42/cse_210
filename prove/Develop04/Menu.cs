class Menu
{
    public int DisplayMenu()
    {
        int repsonse = 0;

        while(repsonse < 1 || repsonse > 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Exit");

            try
            {
                repsonse = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter an integer between 1 and 4.");
            }
        }
        return repsonse;
    }
}