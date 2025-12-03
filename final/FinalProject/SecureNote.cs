public class SecureNote : VaultItem
{
    public string NoteBody { get; set; }

    public override string GetItemType() => "Secure Note";

    public override string GetMaskedDisplay()
    {
        if (NoteBody.Length <= 20)
            return NoteBody;
        return NoteBody.Substring(0, 20) + "...";
    }

    public override string GetFullDisplay()
    {
        return $"Note: {NoteBody}";
    }
}
