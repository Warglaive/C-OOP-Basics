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
            var inputArgs = input.Split(' ');
            var command = inputArgs[0];
            var accountId = int.Parse(inputArgs[1]);
            acc.Id = accountId;
            switch (command)
            {
                case "Create":
                    if (accountsDB.ContainsKey(accountId))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        acc.Id = accountId;
                        accountsDB.Add(accountId, acc);
                    }
                    break;
                case "Deposit":
                    var amount = int.Parse(inputArgs[2]);
                    if (!accountsDB.ContainsKey(accountId))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        accountsDB[accountId].Deposit(amount);
                    }
                    break;
                case "Withdraw":
                    var withdrawAmount = decimal.Parse(inputArgs[2]);
                    if (!accountsDB.ContainsKey(accountId))
                    {
                        Console.WriteLine("Account does not exist");
                        break;
                    }
                    if (withdrawAmount > acc.Balance)
                    {
                        Console.WriteLine("Insufficient balance");
                    }
                    else
                    {
                        acc.Withdraw(withdrawAmount);
                    }
                    break;
                case "Print":
                    if (!accountsDB.ContainsKey(accountId))
                    {
                        Console.WriteLine("Account does not exist");
                        break;
                    }
                    Console.WriteLine($"Account ID{acc.Id}" +
                                      $", balance {acc.Balance:f2}");
                    break;
            }
            input = Console.ReadLine();
        }
    }
}