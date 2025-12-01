using System;

public abstract class VaultItem
{
    public string Title { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public abstract string GetItemType();
    public abstract string GetMaskedDisplay();
}
