using System;

class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new Menu();
        int userSelection;
        bool done = false;

        Entry entry = null;
        Journal journal = new Journal();

        do
        {
            userSelection = journalMenu.ProcessMenu();

            switch (userSelection)
            {
                case 1:
                    //Create a new Entry object
                    entry = new Entry();
                    
                    //Call create on that object
                    entry.GetPrompt();
                    entry.inputEntry();

                    entry._date = DateTime.Now.ToShortDateString();

                    //Add the entry to the journal
                    journal.AddEntry(entry);
                    break;
                case 2:
                    //Call journal.Display()
                    journal.Display();
                    break;
                case 3:
                    //Save to a file
                    Console.WriteLine("What is the filename? (i.e journal.txt): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case 4:
                    //Read from a file
                    break;
                case 5:
                    done = true;
                    break;
            }
        } while (!done);
    }
}