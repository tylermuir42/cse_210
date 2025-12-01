using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Password Manager";

        AuthenticationService auth = new AuthenticationService();
        Menu menu = new Menu();
        VaultManager vaultManager = new VaultManager();
        StorageService storage = new StorageService();
        EncryptionService encryption = new EncryptionService();

        Console.Clear();
        Console.WriteLine("==== PASSWORD MANAGER ====");
        Console.Write("Enter Master Password: ");
        string masterPassword = Console.ReadLine();

        if (!auth.VerifyMasterPassword(masterPassword))
        {
            Console.WriteLine("Incorrect password. Exiting...");
            return;
        }

        // Attempt to load vault
        vaultManager.Items = storage.LoadVault(masterPassword);

        bool running = true;

        while (running)
        {
            int choice = menu.DisplayMenu();

            switch (choice)
            {
                case 1:
                    vaultManager.AddItemWorkflow();
                    break;
                case 2:
                    vaultManager.ListItemsWorkflow();
                    break;
                case 3:
                    vaultManager.SearchItemsWorkflow();
                    break;
                case 4:
                    storage.SaveVault(vaultManager.Items, masterPassword);
                    running = false;
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
