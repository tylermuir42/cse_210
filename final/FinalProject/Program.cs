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

        string defaultFile = "vault.dat";

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
        vaultManager.Items = storage.LoadVault(masterPassword, defaultFile);
        if(vaultManager.Items.Count > 0)
        {
            Console.WriteLine($"Loaded {vaultManager.Items.Count} items from vault.");
            System.Threading.Thread.Sleep(1000);
        }

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
                    vaultManager.ListItemsWorkflow(auth, masterPassword);
                    break;
                case 3:
                    vaultManager.SearchItemsWorkflow();
                    break;
                case 4:
                    Console.Write("Enter filename to save (press Enter for default 'vault.dat'): ");
                    string filename = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(filename)) filename = defaultFile;

                    storage.SaveVault(vaultManager.Items, masterPassword, filename);
                    Console.WriteLine($"Vault saved to {filename}. (Encrypted) Press any key to continue");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Exiting program...");
                    running = false;
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}
