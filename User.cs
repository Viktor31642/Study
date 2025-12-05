public class User
{
    private string password;

    public void SetPassword(string pass)
    {
        if (pass.Length < 5)
        {
            Console.WriteLine("Your password is too short");
            return;
        }

        password = pass;
    }

    public bool CheckPassword(string pass)
    {
        return pass == password;
    }
}