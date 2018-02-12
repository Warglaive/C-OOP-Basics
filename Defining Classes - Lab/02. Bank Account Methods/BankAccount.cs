using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


public class BankAccount
{
    private int id;
    private decimal balance;

    public int Id { get; set; }
    public decimal Balance { get; set; }

    public void Deposit(decimal amount)
    {
        balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        balance -= amount;
    }

    public override string ToString()
    {
        return $"Account {this.Id}, balance {this.Balance}";
    }
}

