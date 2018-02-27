using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        if (name.Length < 3)
        {
            throw new ArgumentException("Name's length should not be less than 3 symbols!");
        }
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Name's length should not be less than 3 symbols!");
            }
            name = value;
        }
    }

    public virtual int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age must be positive!");
            }
            if (value > 15)
            {
                throw new ArgumentException("Child's age must be less than 15!");
            }
            age = value;
        }
    }
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(string.Format($"Name: {Name}, Age: {Age}"));
        return stringBuilder.ToString();
    }
}

