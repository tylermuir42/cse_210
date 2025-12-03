using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class StorageService
{
    private EncryptionService _encryption = new EncryptionService();
    public void SaveVault(List<VaultItem> items, string key, string filename)
    {
        string json = JsonSerializer.Serialize(items, new JsonSerializerOptions()
        {
            WriteIndented = true
        });
        string encryptedJson = _encryption.Encrypt(json, key);
        File.WriteAllText(filename, encryptedJson);
    }

    public List<VaultItem> LoadVault(string key, string filename)
    {
        if (!File.Exists(filename))
            return new List<VaultItem>();

        string encryptedContent = File.ReadAllText(filename);

        try
        {
            string json = _encryption.Decrypt(encryptedContent, key);
            return JsonSerializer.Deserialize<List<VaultItem>>(json);
        }
        catch
        {
            Console.WriteLine("Failed to load vault. Password may be incorrect or file corrupted.");
            return new List<VaultItem>();
        }
    }
}
