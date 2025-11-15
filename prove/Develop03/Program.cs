using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        while (true)
        {
            Console.Clear();
            scripture.ShowScripture();

            if (!scripture.HideWords())
            {
                Console.WriteLine("\nAll words are hidden. Press enter to quit.");
                Console.ReadLine();
                break;
            }

            Console.WriteLine("\nPress enter to hide more words, or press q to quit.");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "q")
            {
                break;
            }
            
        }
    }
}