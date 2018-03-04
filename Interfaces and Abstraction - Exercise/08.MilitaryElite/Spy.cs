using System;
using System.Collections.Generic;
using System.Text;


public class Spy : ISoldier, ISpy
{
    public Spy(int codeNumber, string firstName,
        string lastName, string id)
    {
        this.CodeNumber = codeNumber;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Id = id;
    }

    public int CodeNumber { get; }
    public string Id { get; }
    public string FirstName { get; }
    public string LastName { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Spy:")
            .AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}")
            .AppendLine($"Code Number: {this.CodeNumber}");
        return sb.ToString();
    }
}