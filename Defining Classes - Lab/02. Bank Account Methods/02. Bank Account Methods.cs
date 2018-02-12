using System;

public class Program
{
    public static void Main()
    {
        var acc = new BankAccount();
        acc.Id = 1;
        acc.Deposit(15);
        acc.Withdraw(10);
        acc.ToString();
        //Console.WriteLine(acc.ToString());
    }
}

