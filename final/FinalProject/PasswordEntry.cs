public class PasswordEntry : VaultItem
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Url { get; set; }

    public override string GetItemType() => "Password";
    public override string GetMaskedDisplay() => "******";
    public override string GetFullDisplay()
    {
        return $"URL: {Url}\nUsername: {Username}\nPassword: {Password}";
    }
}
