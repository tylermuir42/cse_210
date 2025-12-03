using System.Text;

public class EncryptionService
{
    // Using a XOR encryption for simplicity. Not secure for real applications.

    public string Encrypt(string input, string key)
    {
        if (string.IsNullOrEmpty(input)) return input;

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            char c = (char)(input[i] ^ key[i % key.Length]);
            sb.Append(c);
        }
        return sb.ToString();
    }

    public string Decrypt(string cipher, string key)
    {
        return Encrypt(cipher, key); // Temporary
    }
}
