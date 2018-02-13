using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {

        //Arrange
        BankAccount bankAccount = new BankAccount();
        bankAccount.Deposit(50);
        BankAccount secondAccount = new BankAccount();
        secondAccount.Deposit(25);
        BankAccount thirdAccount = new BankAccount();
        thirdAccount.Deposit(15);

        var bankAccs = new List<BankAccount> { bankAccount, secondAccount, thirdAccount };

        Person person = new Person("pesho", 25, bankAccs);

        //Act
        decimal balance = person.GetBalance();

    }
}

