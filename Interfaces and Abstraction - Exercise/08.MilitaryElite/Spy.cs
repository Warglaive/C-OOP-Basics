using System;
using System.Collections.Generic;
using System.Text;


public class Spy : ISoldier, ISpy
{
    public Spy(int codeNumber, string firstName, 
        string lastName, string id)
    {
        CodeNumber = codeNumber;
        FirstName = firstName;
        LastName = lastName;
        Id = id;
    }

    public int CodeNumber { get; }
    public string Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
}