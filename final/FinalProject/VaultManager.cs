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

    public void ListItemsWorkflow()
    {
        Console.Clear();
        Console.WriteLine("==== STORED ITEMS ====");

        for (int i = 0; i < Items.Count; i++)
        {
            var item = Items[i];
            Console.WriteLine($"{i + 1}. [{item.GetItemType()}] {item.Title} -> {item.GetMaskedDisplay()}");
        }

        Console.ReadKey();
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
