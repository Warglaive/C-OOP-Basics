using System;
using System.Collections.Generic;
using System.Text;


public class Private : ISoldier, IPrivate
{
    public Private(string id
        , string firstName, string lastName, double salary)
    {
        Salary = salary;
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public double Salary { get; }
    public string Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary}");
        return sb.ToString();
    }
}