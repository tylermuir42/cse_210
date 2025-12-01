using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class StorageService
{
    private readonly string filePath = "vault.dat";

    public void SaveVault(List<VaultItem> items, string key)
    {
        string json = JsonSerializer.Serialize(items, new JsonSerializerOptions()
        {
            WriteIndented = true,
            IncludeFields = true
        });

        File.WriteAllText(filePath, json);
    }

    public List<VaultItem> LoadVault(string key)
    {
        if (!File.Exists(filePath))
            return new List<VaultItem>();

        string json = File.ReadAllText(filePath);

        try
        {
            return JsonSerializer.Deserialize<List<VaultItem>>(json);
        }
        catch
        {
            return new List<VaultItem>();
        }
    }
}
