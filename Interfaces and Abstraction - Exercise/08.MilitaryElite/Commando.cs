using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Commando : ISoldier, IPrivate, ISpecialisedSoldier, ICommando
{
    public Commando(string corps, List<Missions> setOfMissions, string id, string firstName, string lastName, double salary)
    {
        this.Corps = corps;
        this.SetOfMissions = setOfMissions;
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Salary = salary;
    }

    public List<Missions> SetOfMissions { get; }
    public string Corps { get; }

    public void CompleteMission()
    {
        //not usable
        foreach (var curreMission in SetOfMissions)
        {
            curreMission.State = "Finished";
        }
    }

    public string Id { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public double Salary { get; }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}")
            .AppendLine($"Corps: {this.Corps}")
            .AppendLine("Missions: ");

        foreach (var currentMission in SetOfMissions)
        {
            sb.AppendLine(currentMission.ToString());
        }
        return sb.ToString();
    }
}