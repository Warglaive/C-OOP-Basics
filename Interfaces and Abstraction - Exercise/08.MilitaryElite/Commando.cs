﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Commando : SpecialisedSoldier, ICommando
{
    private ICollection<IMission> missions;
    public Commando(int id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        missions = new List<IMission>();
    }

    public IReadOnlyCollection<IMission> Missions =>
        (IReadOnlyCollection<IMission>)missions;
    public void AddMission(IMission mission)
    {
        this.missions.Add(mission);
    }

    public void CompleteMission(string missionCodeName)
    {
        IMission mission = this.Missions.FirstOrDefault(m => m.CodeName == missionCodeName);
        if (mission == null)
        {
            throw new ArgumentException("Mission not found");
        }
        mission.Complete();
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString())
            .AppendLine($"{nameof(this.Corps)}: {this.Corps.ToString()}")
            .AppendLine($"{nameof(this.Missions)}:");

        foreach (var currentMission in this.Missions)
        {
            sb.AppendLine($"  {currentMission.ToString()}");
        }
        var result = sb.ToString().TrimEnd();
        return result;
    }
}