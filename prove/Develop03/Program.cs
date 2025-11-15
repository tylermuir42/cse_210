using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Scripture scripture2 = new Scripture("Jacob", 4, 12, "And now, beloved, marvel not that I tell you these things; for why not speak of the atonement of Christ, and attain to a perfect knowledge of him, as to attain to the knowledge of a resurrection and the world to come?");
        Scripture scripture3 = new Scripture("D&C", 123, 17, "Therefore, dearly beloved brethren, let us cheerfully do all things that lie in our power; and then may we stand still, with the utmost assurance, to see the salvation of God, and for his arm to be revealed.");
        Scripture scripture4 = new Scripture("D&C", 130, 20, 21, "20 There is a law, irrevocably decreed in heaven before the foundations of this world, upon which all blessings are predicated— And when we obtain any blessing from God, it is by obedience to that law upon which it is predicated.");

        List<Scripture> allScriptures = new List<Scripture>
        {
            scripture1, scripture2, scripture3, scripture4
        };

        Random rand = new Random();
        int index = rand.Next(allScriptures.Count);
        Scripture scripture = allScriptures[index];

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