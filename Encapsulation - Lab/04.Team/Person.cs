using System;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salaryDecimal;

    public decimal Salary
    {
        get { return salaryDecimal; }
        set
        {
            if (salaryDecimal < 460)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva!");
            }
            salaryDecimal = value;
        }
    }
    public string FirstName
    {
        get { return firstName; }
        set
        {
            if (firstName?.Length < 3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            firstName = value;
        }
    }
    public string LastName
    {
        get { return lastName; }
        set
        {
            if (lastName?.Length < 3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            lastName = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (age < 1)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            age = value;
        }
    }
    public Person(string FirstName, string LastName, int Age, decimal Salary)
    {
        this.firstName = FirstName;

        this.lastName = LastName;
        if (firstName?.Length < 3)
        {
            throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
        }
        if (lastName?.Length < 3)
        {
            throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
        }
        this.age = Age;
        this.salary = Salary;
    }
    private decimal salary;

    public void IncreaseSalary(decimal percentage)
    {
        if (this.Age > 30)
        {
            this.salary += this.salary * percentage / 100;
        }
        else
        {

            this.salary += this.salary * percentage / 200;
        }
    }
    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} gets {this.salary:f2} leva.";
    }
}