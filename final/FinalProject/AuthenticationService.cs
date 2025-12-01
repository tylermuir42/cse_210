public class AuthenticationService
{
    // WARNING: Not secure — just for course purposes.

    private string masterPassword = "password123"; // You can enhance this later.

    public bool VerifyMasterPassword(string input)
    {
        return input == masterPassword;
    }
}
