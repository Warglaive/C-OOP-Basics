using System;
using System.Collections.Generic;
using System.Text;


public class Commando : ISpecialisedSoldier, ICommando
{
    public Commando(string corps, List<Missions> setOfMissions)
    {
        Corps = corps;
        SetOfMissions = setOfMissions;
    }

    public List<Missions> SetOfMissions { get; }
    public string Corps { get; }

    public void CompleteMission(string command)
    {
        //change state of mission to completed
    }
}