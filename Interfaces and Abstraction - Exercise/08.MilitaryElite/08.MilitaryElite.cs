using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main()
    {
        var soldiers = new List<ISoldier>();
        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] tokens = input.Split();
            var soldierType = tokens[0];
            var id = int.Parse(tokens[1]);
            var firstName = tokens[2];
            var lastName = tokens[3];
            var salary = decimal.Parse(tokens[4]);

            ISoldier soldier = null;

            try
            {
                switch (soldierType)
                {
                    case "Private":
                        soldier = new Private(id, firstName, lastName, salary);
                        break;
                    case "LeutenantGeneral":
                        var lieutenant = new LeutenantGeneral(id, firstName, lastName, salary);
                        for (int i = 5; i < tokens.Length; i++)
                        {
                            var privateId = int.Parse(tokens[i]);
                            ISoldier @private = soldiers.First(p => p.Id == privateId);
                            lieutenant.AddPrivate(@private);
                        }
                        soldier = lieutenant;
                        break;
                    case "Engineer":
                        string engineerCorps = tokens[5];
                        var engineer = new Engineer(id, firstName, lastName, salary, engineerCorps);
                        for (int i = 6; i < tokens.Length; i++)
                        {
                            var partName = tokens[i];
                            var hoursWorked = int.Parse(tokens[++i]);
                            try
                            {
                                IRepair repair = new Repair(partName, hoursWorked);
                                engineer.AddRepair(repair);
                            }
                            catch { }
                        }
                        soldier = engineer;
                        break;
                    case "Commando":
                        string commandoCorps = tokens[5];
                        var commando = new Commando(id, firstName, lastName, salary, commandoCorps);
                        //
                        for (int i = 6; i < tokens.Length; i++)
                        {
                            var codeName = tokens[i];
                            var missionState = tokens[++i];
                            try
                            {
                                IMission mission = new Mission(codeName, missionState);
                                commando.AddMission(mission);
                            }
                            catch { }
                        }
                        soldier = commando;
                        //
                        break;
                    case "Spy":
                        int codeNumber = (int)salary;
                        soldier = new Spy(id, firstName, lastName, codeNumber);
                        break;
                    default:
                        throw new ArgumentException("Invalid Soldier Type");
                }
                soldiers.Add(soldier);
            }
            catch (Exception e)
            {
            //    Console.WriteLine(e.Message);
            }
        }
        foreach (var s in soldiers)
        {
            Console.WriteLine(s);
        }
    }
}