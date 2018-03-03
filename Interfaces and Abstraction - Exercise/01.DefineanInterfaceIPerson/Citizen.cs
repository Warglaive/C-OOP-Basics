using System;
using System.Collections.Generic;
using System.Text;


public class Citizen : IPerson
{
    public string Name { get; }
    public int Age { get; }

    public Citizen(string name, int age)
    {
        this.Age = age;
        this.Name = name;
    }
}