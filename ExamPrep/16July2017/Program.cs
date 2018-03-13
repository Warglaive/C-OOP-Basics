using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var draftManager = new DraftManager();
        var inputCommands = Console.ReadLine()
            .Split().ToList();
        double totalEnergy = 0;
        double totalOre = 0;
        while (inputCommands[0] != "Shutdown")
        {
            var command = inputCommands[0];
            //NOTE: DraftManager class methods are called from the outside so these methods must NOT receive the command parameter as part of the arguments!
            switch (command)
            {
                case "RegisterHarvester":
                    Console.WriteLine(draftManager.RegisterHarvester(inputCommands));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(draftManager.RegisterProvider(inputCommands));
                    break;
                case "Day":
                    var providedEnergy = draftManager
                        .providers.Sum(x => x.EnergyOutput);
                    var requiredEnergy = draftManager.harvesters
                        .Sum(h => h.EnergyRequirement);

                    totalEnergy += providedEnergy;

                    //
                    if (totalEnergy >= requiredEnergy)
                    {
                        totalOre += draftManager
                            .harvesters.Sum(x => x.OreOutput);

                    }
                    //
                    Console.WriteLine(draftManager.Day(totalOre, providedEnergy));
                    break;
            }
            inputCommands = Console.ReadLine()
                .Split().ToList();
        }
    }
}