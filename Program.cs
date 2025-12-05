using System.Reflection.Metadata.Ecma335;

static void Main() {}

// var words = new List<string> { "cat", "beautiful", "sky", "mountain", "queue" };

// var theloggestword = words[0];
// int maxVowels = 0;

// foreach (var word in words)
// {
//     int count = 0;

//     foreach (var letter in word)
//     {
//         if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
//             count++;
//     }

//     if (count > maxVowels)
//     {
//         maxVowels = count;
//         theloggestword = word;
//     }
// }

// Console.WriteLine(theloggestword);



// string sentence = "apple orange banana apple kiwi banana apple";
// var words = sentence.Split(' ');
// String popularword = words[0];
// int maxCount = 1;
// foreach(var word in words)
// { int count = 0;
// foreach(var w in words)
//     {
//         if (w == word)
//         {
//             count++;
//             if (count > maxCount)
//             {
//                maxCount = count;
//             }
//           popularword = word;
//         }

//     }
   
// }

//  Console.WriteLine(popularword);

// Інкапсуляція

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




