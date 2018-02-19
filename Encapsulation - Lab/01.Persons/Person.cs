using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string firstName;
    private string lastName;
    private int age;
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
    public Person(string FirstName, string LastName, int Age)
    {
        this.firstName = FirstName;
        this.lastName = LastName;
        this.age = Age;
    }

    public override string ToString()
    {
        return $"{this.firstName} {this.lastName} is {this.age} years old.";
    }
}
