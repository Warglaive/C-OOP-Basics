using System;
using System.Collections.Generic;
using System.Text;


public class Engineer : ISoldier, IPrivate, ISpecialisedSoldier, IEngineer
{
    public Engineer(List<Repair> setOfRepairs, string corps, string id, string firstName, string lastName, double salary)
    {
        this.SetOfRepairs = setOfRepairs;
        this.Corps = corps;
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Salary = salary;
    }

    public List<Repair> SetOfRepairs { get; }
    public string Corps { get; }
    public string Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public double Salary { get; }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}")
            .AppendLine($"Corps: {this.Corps}");

        foreach (var currentRepair in SetOfRepairs)
        {
            sb.AppendLine(currentRepair.ToString());
        }
        return sb.ToString();
    }
}