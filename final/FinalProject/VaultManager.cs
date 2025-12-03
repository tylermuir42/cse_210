using System;
using System.Collections.Generic;

public class VaultManager
{
    public List<VaultItem> Items { get; set; } = new List<VaultItem>();

    public void AddItem(VaultItem item)
    {
        Items.Add(item);
    }

    // ---------- WORKFLOW METHODS FOR MENU ----------
    public void AddItemWorkflow()
    {
        Console.Clear();
        Console.WriteLine("1. Add Password Entry");
        Console.WriteLine("2. Add Secure Note");
        Console.WriteLine("3. Add Credit Card");
        Console.Write("Choose: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                CreatePasswordEntry();
                break;
            case "2":
                CreateSecureNote();
                break;
            case "3":
                CreateCreditCardEntry();
                break;
        }
    }

    private void CreatePasswordEntry()
    {
        Console.Clear();
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        Console.Write("URL: ");
        string url = Console.ReadLine();

        PasswordEntry entry = new PasswordEntry()
        {
            Title = title,
            Username = username,
            Password = password,
            Url = url
        };

        AddItem(entry);
        Console.WriteLine("Password saved!");
        Console.ReadKey();
    }

    private void CreateSecureNote()
    {
        Console.Clear();
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Note Body: ");
        string body = Console.ReadLine();

        SecureNote note = new SecureNote()
        {
            Title = title,
            NoteBody = body
        };

        AddItem(note);
        Console.WriteLine("Note saved!");
        Console.ReadKey();
    }

    private void CreateCreditCardEntry()
    {
        Console.Clear();
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Card Number: ");
        string number = Console.ReadLine();
        Console.Write("Expiration (MM/YY): ");
        string exp = Console.ReadLine();
        Console.Write("CVV: ");
        string cvv = Console.ReadLine();

        CreditCardEntry card = new CreditCardEntry()
        {
            Title = title,
            CardNumber = number,
            Expiration = exp,
            CVV = cvv
        };

        AddItem(card);
        Console.WriteLine("Card saved!");
        Console.ReadKey();
    }

    public void ListItemsWorkflow(AuthenticationService auth, string masterPassword)
    {
        Console.Clear();
        Console.WriteLine("==== Stored Items ====");

        if (Items.Count == 0)
        {
            Console.WriteLine("Vault is empty.");
            Console.ReadKey();
            return;
        }

        for (int i = 0; i < Items.Count; i++)
        {
            var item = Items[i];
            Console.WriteLine($"{i + 1}. [{item.GetItemType()}] {item.Title} -> {item.GetMaskedDisplay()}");
        }

        Console.WriteLine("-----------------------");
        Console.WriteLine("Press [R] to Reveal an item, or any other key to return to menu.");
        ConsoleKeyInfo key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.R)
        {
            Console.WriteLine();
            Console.Write("Verify master password to reveal: ");
            string inputPass = Console.ReadLine();

            if (auth.VerifyMasterPassword(inputPass))
            {
                Console.Write("Enter the ID number of the item to reveal: ");
                if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= Items.Count)
                {
                    var selectedItem = Items[index - 1];
                    Console.WriteLine("\n--- SECRET REVEALED ---");
                    Console.WriteLine($"Title: {selectedItem.Title}");
                    Console.WriteLine(selectedItem.GetFullDisplay());
                    Console.WriteLine("-----------------------");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid item number.");
                }
            }
            else
            {
                Console.WriteLine("Wrong Password! Access Denied.");
            }
            Console.WriteLine("Press any key to return to menu.");
            Console.ReadKey();
        }
    }

    public void SearchItemsWorkflow()
    {
        Console.Clear();
        Console.Write("Enter search term: ");
        string query = Console.ReadLine();

        foreach (var item in Items)
        {
            if (item.Title.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"[{item.GetItemType()}] {item.Title}");
            }
        }

        Console.ReadKey();
    }
}
