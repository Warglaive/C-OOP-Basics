using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var accountsDB = new Dictionary<int, BankAccount>();
        var input = Console.ReadLine();
        var acc = new BankAccount();
        while (input != "End")
        {
            var inputArgs = input.Split();
            var command = inputArgs[0];
            var accountId = int.Parse(inputArgs[1]);
            acc.Id = accountId;
            switch (command)
            {
                case "Create":
                    Create(accountsDB, accountId, acc);
                    break;
                case "Deposit":
                    Deposit(accountsDB, inputArgs, accountId);
                    break;
                case "Withdraw":
                    Withdraw(accountsDB, inputArgs, accountId);
                    break;
                case "Print":
                    Print(accountsDB, inputArgs, accountId);
                    break;
            }
            input = Console.ReadLine();
        }
    }

    public static void Deposit(Dictionary<int, BankAccount> accountsDB, string[] inputArgs, int accountId)
    {
        var amount = int.Parse(inputArgs[2]);
        if (!accountsDB.ContainsKey(accountId))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            accountsDB[accountId].Deposit(amount);
        }
    }
    public static void Create(Dictionary<int, BankAccount> accountsDB, int accountId, BankAccount acc)
    {
        if (accountsDB.ContainsKey(accountId))
        {
            Console.WriteLine("Account already exists");
        }
        else
        {
            accountsDB.Add(accountId, new BankAccount());
        }
    }
    public static void Withdraw(Dictionary<int, BankAccount> accountsDB, string[] inputArgs, int accountId)
    {
        var withdrawAmount = decimal.Parse(inputArgs[2]);
        if (!accountsDB.ContainsKey(accountId))
        {
            Console.WriteLine("Account does not exist");
            return;
        }
        if (withdrawAmount > accountsDB[accountId].Balance)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            accountsDB[accountId].Withdraw(withdrawAmount);
        }
    }

    public static void Print(Dictionary<int, BankAccount> accountsDB, string[] inputArgs, int accountId)
    {
        if (!accountsDB.ContainsKey(accountId))
        {
            Console.WriteLine("Account does not exist");
            return;
        }
        Console.WriteLine($"Account ID{inputArgs[1]}" +
                          $", balance {accountsDB[accountId].Balance:f2}");
    }
}