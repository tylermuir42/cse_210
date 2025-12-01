public class PasswordEntry : VaultItem
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Url { get; set; }

    public override string GetItemType()
    {
        return "Password";
    }

    public override string GetMaskedDisplay()
    {
        return "******";
    }
}
