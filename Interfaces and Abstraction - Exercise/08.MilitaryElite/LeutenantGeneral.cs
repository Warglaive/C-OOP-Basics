using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : ISoldier, IPrivate, ILeutenantGeneral
{
    public LeutenantGeneral(List<Private> setOfPrivates,
        string id, string firstName, string lastName, double salary)
    {
        SetOfPrivates = setOfPrivates;
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public List<Private> SetOfPrivates { get; }
    public string Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public double Salary { get; }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id:" +
                      $" {this.Id} Salary: {this.Salary:f2}")
                      .AppendLine($"Privates:");
        foreach (var currentPrivate in SetOfPrivates)
        {
            sb.AppendLine($"  Name: {currentPrivate.FirstName} {currentPrivate.LastName} Id: {currentPrivate.Id} Salary: {currentPrivate.Salary:f2}");
        }

        return sb.ToString();
    }
}

