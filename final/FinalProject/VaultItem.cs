using System;
using System.Text.Json.Serialization;

[JsonDerivedType(typeof(PasswordEntry), typeDiscriminator: "password")]
[JsonDerivedType(typeof(SecureNote), typeDiscriminator: "note")]
[JsonDerivedType(typeof(CreditCardEntry), typeDiscriminator: "card")]

public abstract class VaultItem
{
    public string Title { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public abstract string GetItemType();
    public abstract string GetMaskedDisplay();

    public abstract string GetFullDisplay();
}
