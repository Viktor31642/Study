public class BankAccount
{
    private decimal balance;
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }
    public bool Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Get your money");
            return true;

        }
        else
        {
            Console.WriteLine("You don`t have money");
            return false;
        }

    }

    public decimal GetBalance() { return balance; }
}

