using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var setOfPrivates = new List<Private>();
        while (input != "End")
        {
            var inputArgs = input.Split(new[] { ' ' }
            , StringSplitOptions.RemoveEmptyEntries);

            var soldierType = inputArgs[0];

            switch (soldierType)
            {
                case "Private":
                    var currentPrivate = ReadPrivate(inputArgs);
                    setOfPrivates.Add(currentPrivate);
                    Console.WriteLine(currentPrivate);
                    break;
                case "LeutenantGeneral":
                    var currentLeutenantGeneral = ReadLeutenantGeneral(inputArgs, setOfPrivates);
                    Console.WriteLine(currentLeutenantGeneral);
                    break;
                case "Engineer":
                    var currentEngineer = ReadEngineer(inputArgs);
                    Console.WriteLine(currentEngineer);
                    break;
                case "Commando":
                    var currentCommando = ReadCommando(inputArgs);
                   // currentCommando.CompleteMission();
                    Console.WriteLine(currentCommando);
                    break;
                case "Spy":
                    var currentSpy = ReadSpy(inputArgs);
                    Console.WriteLine(currentSpy);
                    break;
            }
            input = Console.ReadLine();
        }
    }

    private static Spy ReadSpy(string[] inputArgs)
    {
        var id = inputArgs[1];
        var firstName = inputArgs[2];
        var lastName = inputArgs[3];
        var codeNumber = int.Parse(inputArgs[4]);
        var currentSpy = new Spy(codeNumber, firstName, lastName, id);
        return currentSpy;
    }

    private static Commando ReadCommando(string[] inputArgs)
    {
        var id = inputArgs[1];
        var firstName = inputArgs[2];
        var lastName = inputArgs[3];
        var salary = double.Parse(inputArgs[4]);
        var corps = inputArgs[5];

        var missionsList = new List<Missions>();
        var codeName = string.Empty;
        var state = string.Empty;
        //
        for (int i = 6; i < inputArgs.Length - 1; i += 2)
        {
            codeName = inputArgs[i];
            state = inputArgs[i + 1];

            if (codeName != string.Empty && state != string.Empty)
            {
                var mission = new Missions(codeName, state);
                if (mission.State != null && mission.CodeName != null)
                {
                    missionsList.Add(mission);
                }
            }
        }
        var currentCommando = new Commando(corps, missionsList, id, firstName, lastName, salary);
        return currentCommando;
        //
    }

    private static Engineer ReadEngineer(string[] inputArgs)
    {
        var engineerId = inputArgs[1];
        var engineerFirstName = inputArgs[2];
        var engineerLastName = inputArgs[3];
        var engineerSalary = double.Parse(inputArgs[4]);
        var engineerCorps = inputArgs[5];

        var repairsList = new List<Repair>();

        var repairPart = string.Empty;
        var repairHours = -1;
        for (int i = 6; i < inputArgs.Length - 1; i += 2)
        {
            repairPart = inputArgs[i];

            repairHours = int.Parse(inputArgs[i + 1]);

            if (repairPart != string.Empty && repairHours > -1)
            {
                var repair = new Repair(repairPart, repairHours);
                repairsList.Add(repair);
            }
        }

        var currentEngineer = new Engineer(repairsList, engineerCorps, engineerId,
            engineerFirstName, engineerLastName, engineerSalary);
        return currentEngineer;
    }

    private static LeutenantGeneral ReadLeutenantGeneral(string[] inputArgs, List<Private> setOfPrivates)
    {
        var privatesIDs = new List<string>();

        var id = inputArgs[1];
        var firstName = inputArgs[2];
        var lastName = inputArgs[3];
        var salary = double.Parse(inputArgs[4]);

        for (int i = 5; i <= inputArgs.Length - 1; i++)
        {
            privatesIDs.Add(inputArgs[i]);
        }
        // bug maybe 
        var privatesToAdd = new List<Private>();
        var temp = new List<Private>();
        foreach (var currentId in privatesIDs)
        {
            temp = setOfPrivates
               .Where(p => p.Id == currentId)
               .ToList();
            privatesToAdd.Add(temp[0]);
            temp.Clear();
        }

        var currentLeutenantGeneral = new LeutenantGeneral(privatesToAdd, id, firstName, lastName, salary);
        return currentLeutenantGeneral;
    }

    private static Private ReadPrivate(string[] inputArgs)
    {
        var id = inputArgs[1];
        var firstName = inputArgs[2];
        var lastName = inputArgs[3];
        var salary = double.Parse(inputArgs[4]);
        var currentPrivate = new Private(id, firstName, lastName, salary);
        return currentPrivate;
    }
}