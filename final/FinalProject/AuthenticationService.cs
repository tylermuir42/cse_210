public class AuthenticationService
{
    // WARNING: Not secure — just for course purposes.

    private string masterPassword = "password123"; // This is the password to log into the program

    public bool VerifyMasterPassword(string input)
    {
        return input == masterPassword;
    }
}
