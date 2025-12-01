public class CreditCardEntry : VaultItem
{
    public string CardNumber { get; set; }
    public string Expiration { get; set; }
    public string CVV { get; set; }

    public override string GetItemType()
    {
        return "CreditCard";
    }

    public override string GetMaskedDisplay()
    {
        if (CardNumber.Length >= 4)
            return "**** **** **** " + CardNumber.Substring(CardNumber.Length - 4);
        return "****";
    }
}
