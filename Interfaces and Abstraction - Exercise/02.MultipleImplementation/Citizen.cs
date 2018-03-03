using System;
using System.Collections.Generic;
using System.Text;


public class Citizen : IPerson, IIdentifiable, IBirthable
{
    public string Name { get; }
    public int Age { get; }

    public Citizen(string name, int age, string id, string birthDate)
    {
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthDate;
        this.Name = name;
    }

    public string Id { get; }
    public string Birthdate { get; }
}