public class SecureNote : VaultItem
{
    public string NoteBody { get; set; }

    public override string GetItemType()
    {
        return "SecureNote";
    }

    public override string GetMaskedDisplay()
    {
        if (NoteBody.Length <= 20)
            return NoteBody;
        return NoteBody.Substring(0, 20) + "...";
    }
}
