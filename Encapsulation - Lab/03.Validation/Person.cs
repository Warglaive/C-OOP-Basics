using System;
using System.Xml.Serialization;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salaryDecimal;

    public decimal Salary
    {
        get => salaryDecimal;
        set => salaryDecimal = value;
    }
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public Person(string FirstName, string LastName, int Age, decimal Salary)
    {
        this.firstName = FirstName;
        this.lastName = LastName;
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

    public void validateAge(int age)
    {
        if (age < 1)
        {
            throw new ArgumentException("Age cannot be zero or a negative integer!");
        }
        this.age = age;
    }
    public void ValidateSalary(decimal salary)
    {
        if (salary < 460)
        {
            throw new ArgumentException("Salary cannot be less than 460 leva!");
        }
        this.salary = salary;
    }

    public void ValidateFirstName(string firstName)
    {
        if (firstName.Length < 3)
        {
            throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
        }
        this.firstName = firstName;
    }
    public void ValidateLastName(string lastName)
    {
        if (lastName.Length < 3)
        {
            throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
        }
        this.lastName = lastName;
    }
    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} gets {this.salary:f2} leva.";
    }
}