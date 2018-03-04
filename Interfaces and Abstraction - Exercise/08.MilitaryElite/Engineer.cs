using System;
using System.Collections.Generic;
using System.Text;


public class Engineer : ISoldier, IPrivate, ISpecialisedSoldier, IEngineer
{
    public Engineer(List<Repair> setOfRepairs, string corps)
    {
        SetOfRepairs = setOfRepairs;
        Corps = corps;
    }

    public List<Repair> SetOfRepairs { get; }
    public string Corps { get; }
    public string Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public double Salary { get; }
}