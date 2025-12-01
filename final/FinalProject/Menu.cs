class Menu
{
    public int DisplayMenu()
    {
        int response = 0;

        while (response < 1 || response > 4)
        {
            Console.Clear();

            Console.WriteLine("==== PASSWORD MANAGER ====");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Add New Item");
            Console.WriteLine("2. View All Items");
            Console.WriteLine("3. Search Items");
            Console.WriteLine("4. Save & Exit");

            try
            {
                response = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter an integer between 1 and 4.");
            }
        }
        return response;
    }
}
