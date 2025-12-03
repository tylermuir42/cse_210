public class CreditCardEntry : VaultItem
{
    public string CardNumber { get; set; }
    public string Expiration { get; set; }
    public string CVV { get; set; }

    public override string GetItemType() => "Credit Card";

    public override string GetMaskedDisplay()
    {
        if (CardNumber.Length >= 4)
            return "**** **** **** " + CardNumber.Substring(CardNumber.Length - 4);
        return "****";
    }

    public override string GetFullDisplay()
    {
        return $"Card Number: {CardNumber}\nExpiration: {Expiration}\nCVV: {CVV}";
    }
}
