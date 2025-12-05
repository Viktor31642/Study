public class BaseUser
{
    private string secretCode;
    protected string role;

    public void SetRole(string r) {  role = r; }
    public void ShowRole() { Console.WriteLine(role); }
    public void SetSecretCode(string code) { secretCode = code; }
    public void ShowSecretCode() 
    { 
        if (secretCode == null) { Console.WriteLine("No secret code set"); }

        else { Console.WriteLine("Secret code length: " + secretCode.Length); }

    }

}

public class AdminUser : BaseUser
{
    public void PrintAdminInfo()
    {
        Console.WriteLine("Admin user active");
     
    }
}

public class GuestUser : BaseUser 
{
    public void PrintGuestInfo()
    {
        Console.WriteLine("Guest user active");
    }
}